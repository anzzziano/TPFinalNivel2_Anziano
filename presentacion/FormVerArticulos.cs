using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class FormVerArticulos : Form
    {

        private List<Articulo> listaDeArticulo;
        public FormVerArticulos()
        {
            InitializeComponent();
        }

        private void FormVerArticulos_Load(object sender, EventArgs e)
        {
            comboBoxCampo.Items.Add("Marca");
            comboBoxCampo.Items.Add("Categoria");
            comboBoxCampo.Items.Add("Precio");

            cargar();
        }

        private void cargar()
        {
            ArticuloData dataDisc = new ArticuloData();

            try
            {
                listaDeArticulo = dataDisc.listar();
                dgvVerArticulos.DataSource = listaDeArticulo;
                ocultarColumnas();
                loadImage(listaDeArticulo[0].Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvVerArticulos.Columns["Imagen"].Visible = false;
            dgvVerArticulos.Columns["Id"].Visible = false;
        }

        private void loadImage(string image)
        {
            try
            {
                pictureBoxArticulos.Load(image);
            }
            catch (Exception ex)
            {
                pictureBoxArticulos.Load("https://t4.ftcdn.net/jpg/06/71/92/37/360_F_671923740_x0zOL3OIuUAnSF6sr7PuznCI5bQFKhI0.jpg");
            }
        }

        private void dgvVerArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVerArticulos.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dgvVerArticulos.CurrentRow.DataBoundItem;
                loadImage(articuloSeleccionado.Imagen);
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarArticulo_Click(object sender, EventArgs e)
        {
     
            FormAgregarArticulo windowAddArtForm = new FormAgregarArticulo();
            windowAddArtForm.ShowDialog();
            cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            if (dgvVerArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo para modificar");
                return;
            }

            seleccionado = (Articulo)dgvVerArticulos.CurrentRow.DataBoundItem;


            FormAgregarArticulo modificarDisco = new FormAgregarArticulo(seleccionado,false);
            modificarDisco.ShowDialog();
            cargar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar(bool logico = false)
        {
            ArticuloData data = new ArticuloData();
            Articulo articuloSeleccionado;

            if (dgvVerArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo para eliminar");
                return;
            }

            try
            {

                DialogResult respuesta = MessageBox.Show("seguro que desea eliminar?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                //Verificar la respuesta del usuario:
                if (respuesta == DialogResult.Yes)
                {
                    //Seleccionar el disco a eliminar de la celda de la DGV
                    articuloSeleccionado = (Articulo)dgvVerArticulos.CurrentRow.DataBoundItem;

                    data.eliminar(articuloSeleccionado.Id);

                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxBusquedaRapida_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string filtro = textBoxBusquedaRapida.Text;


            if (filtro.Length >= 2)
            {
                listaFiltrada = listaDeArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {

                listaFiltrada = listaDeArticulo;

            }

            dgvVerArticulos.DataSource = null;
            dgvVerArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();

            if (opcion == "Marca")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
            else if (opcion == "Categoria")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
            else if(opcion == "Precio")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            ArticuloData discoData = new ArticuloData();

            try
            {

                if (validarFiltro())
                {
                    return;
                }

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltro.Text;

                try
                {
                    dgvVerArticulos.DataSource = discoData.filtrar(campo, criterio, filtro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private bool validarFiltro()
        {
            if (comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecciona un campo ");
                return true;
            }
            if (comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("por favor, selecciona un criterio");
                return true;
            }
            if (comboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(textBoxFiltro.Text))
                {
                    MessageBox.Show("debe cargar el filtro para la busqueda");
                    return true;
                }
                if (!(soloNumerosYpunto(textBoxFiltro.Text)))
                {
                    MessageBox.Show("solo puede escribir numeros y un punto");
                    return true;
                }

            }
            return false;
        }

        private bool soloNumerosYpunto(string cadena)
        {
            foreach (char caracter in cadena)
            {

                if (!(char.IsNumber(caracter) || caracter == '.' ))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            if (dgvVerArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un articulo para verlo");
                return;
            }

            seleccionado = (Articulo)dgvVerArticulos.CurrentRow.DataBoundItem;


            FormAgregarArticulo modificarDisco = new FormAgregarArticulo(seleccionado,true);
            modificarDisco.ShowDialog();
            cargar();
        }
    }
}
