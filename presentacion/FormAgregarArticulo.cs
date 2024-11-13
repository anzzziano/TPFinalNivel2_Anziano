using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class FormAgregarArticulo : Form
    {

        private Articulo articuloN = null;
        private OpenFileDialog archivo = null;

        public FormAgregarArticulo()
        {
            InitializeComponent();
        }

        public FormAgregarArticulo(Articulo articulo, bool soloVisualizar)
        {
            InitializeComponent();
            this.articuloN = articulo;
            Text = "Modificar articulo";

            if (soloVisualizar) {

                Text = "Ver Articulo";

                foreach (Control controlador in Controls)
                {
                    if (controlador is TextBox)
                    {
                        ((TextBox)controlador).ReadOnly = true;
                    }
                    else if (controlador is Button)
                    {
                        controlador.Enabled = false;   
                    }
                    else if (controlador is ComboBox)
                    {
                        controlador.Enabled = false;
                    }
                }

            }
        }

     

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            loadImage(textBoxImagen.Text);
        }

        private void loadImage(string image)
        {
            try
            {
                pictureBoxAgregarArticulo.Load(image);
            }
            catch (Exception ex)
            {
                pictureBoxAgregarArticulo.Load("https://t4.ftcdn.net/jpg/06/71/92/37/360_F_671923740_x0zOL3OIuUAnSF6sr7PuznCI5bQFKhI0.jpg");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            ArticuloData data = new ArticuloData();

            try
            {
                if (articuloN == null)
                    articuloN = new Articulo();

                if (string.IsNullOrWhiteSpace(textBoxCodigo.Text))
                {
                    MessageBox.Show("debe tener Codigo");
                    return;
                }


                if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    MessageBox.Show("debe tener Nombre");
                    return;
                }

                string precioTexto = textBoxPrecio.Text.Trim(); 

                if (string.IsNullOrWhiteSpace(precioTexto))
                {
                    MessageBox.Show("El precio no puede estar vacío o ser solo espacios.");
                    return;
                }

                articuloN.CodigoArt = textBoxCodigo.Text;
                articuloN.Nombre = textBoxNombre.Text;
                articuloN.Descripcion = textBoxDescripcion.Text;
                articuloN.Imagen = textBoxImagen.Text;
                articuloN.Precio = decimal.Parse(textBoxPrecio.Text);
                articuloN.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                articuloN.Marca = (Marca)comboBoxMarca.SelectedItem;

                if (articuloN.Id != 0)
                {
                    data.modificar(articuloN);
                    MessageBox.Show("modificado exitosamente");
                }

                 if (articuloN.Id == 0)
                {
                    data.agregarArticulo(articuloN);
                    MessageBox.Show("creado exitosamente");
                }

                //guardo imagen si se levanto localmente

                //if (archivo != null && !(textBoxUrlImagen.Text.ToUpper().Contains("HTTP")))
                //{
                //    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                //}

                this.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaDatos categoriaData = new CategoriaDatos();

            MarcaDatos marcaData = new MarcaDatos();

            try
            {

                comboBoxCategoria.DataSource = categoriaData.listar();
                comboBoxCategoria.ValueMember = "Id";
                comboBoxCategoria.DisplayMember = "Descripcion";

                comboBoxMarca.DataSource = marcaData.listar();
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DisplayMember = "Descripcion";

                if (articuloN != null)
                {
                    textBoxCodigo.Text = articuloN.CodigoArt;
                    textBoxNombre.Text = articuloN.Nombre;
                    textBoxDescripcion.Text = articuloN.Descripcion;
                    textBoxImagen.Text = articuloN.Imagen; // bloque para cuando viene un disco para modificat
                    loadImage(articuloN.Imagen);//               porque trae algo adentro porque es distinto de nulo
                    textBoxPrecio.Text = articuloN.Precio.ToString();
                    comboBoxCategoria.SelectedValue = articuloN.Categoria.Id;
                    comboBoxMarca.SelectedValue = articuloN.Marca.Id;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59 ) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                MessageBox.Show("solo puede ingresar numeros o un punto");
                e.Handled = true;
            }
        }

    }
}
