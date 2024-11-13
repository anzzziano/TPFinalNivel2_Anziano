namespace presentacion
{
    partial class FormVerArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxArticulos = new System.Windows.Forms.PictureBox();
            this.dgvVerArticulos = new System.Windows.Forms.DataGridView();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonAgregarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxBusquedaRapida = new System.Windows.Forms.TextBox();
            this.labelSearchFast = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.labelCampo = new System.Windows.Forms.Label();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.labelFiltroAvanzado = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonVerDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxArticulos
            // 
            this.pictureBoxArticulos.Location = new System.Drawing.Point(923, 75);
            this.pictureBoxArticulos.Name = "pictureBoxArticulos";
            this.pictureBoxArticulos.Size = new System.Drawing.Size(304, 371);
            this.pictureBoxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArticulos.TabIndex = 0;
            this.pictureBoxArticulos.TabStop = false;
            // 
            // dgvVerArticulos
            // 
            this.dgvVerArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerArticulos.Location = new System.Drawing.Point(29, 75);
            this.dgvVerArticulos.MultiSelect = false;
            this.dgvVerArticulos.Name = "dgvVerArticulos";
            this.dgvVerArticulos.ReadOnly = true;
            this.dgvVerArticulos.RowHeadersWidth = 51;
            this.dgvVerArticulos.RowTemplate.Height = 24;
            this.dgvVerArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerArticulos.Size = new System.Drawing.Size(855, 371);
            this.dgvVerArticulos.TabIndex = 1;
            this.dgvVerArticulos.SelectionChanged += new System.EventHandler(this.dgvVerArticulos_SelectionChanged);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(1090, 552);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(98, 71);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonAgregarArticulo
            // 
            this.buttonAgregarArticulo.Location = new System.Drawing.Point(29, 465);
            this.buttonAgregarArticulo.Name = "buttonAgregarArticulo";
            this.buttonAgregarArticulo.Size = new System.Drawing.Size(98, 66);
            this.buttonAgregarArticulo.TabIndex = 3;
            this.buttonAgregarArticulo.Text = "Agregar";
            this.buttonAgregarArticulo.UseVisualStyleBackColor = true;
            this.buttonAgregarArticulo.Click += new System.EventHandler(this.buttonAgregarArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(764, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ver articulos diponibles";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(151, 465);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(98, 66);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(277, 465);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(98, 66);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxBusquedaRapida
            // 
            this.textBoxBusquedaRapida.Location = new System.Drawing.Point(151, 33);
            this.textBoxBusquedaRapida.Name = "textBoxBusquedaRapida";
            this.textBoxBusquedaRapida.Size = new System.Drawing.Size(224, 22);
            this.textBoxBusquedaRapida.TabIndex = 7;
            this.textBoxBusquedaRapida.TextChanged += new System.EventHandler(this.textBoxBusquedaRapida_TextChanged);
            // 
            // labelSearchFast
            // 
            this.labelSearchFast.AutoSize = true;
            this.labelSearchFast.Location = new System.Drawing.Point(28, 36);
            this.labelSearchFast.Name = "labelSearchFast";
            this.labelSearchFast.Size = new System.Drawing.Size(117, 16);
            this.labelSearchFast.TabIndex = 8;
            this.labelSearchFast.Text = "Busqueda Rapida";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(85, 571);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCampo.TabIndex = 10;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(319, 574);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCriterio.TabIndex = 11;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(559, 577);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(224, 22);
            this.textBoxFiltro.TabIndex = 12;
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(28, 577);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(51, 16);
            this.labelCampo.TabIndex = 13;
            this.labelCampo.Text = "Campo";
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(264, 579);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(49, 16);
            this.labelCriterio.TabIndex = 14;
            this.labelCriterio.Text = "Criterio";
            // 
            // labelFiltroAvanzado
            // 
            this.labelFiltroAvanzado.AutoSize = true;
            this.labelFiltroAvanzado.Location = new System.Drawing.Point(517, 579);
            this.labelFiltroAvanzado.Name = "labelFiltroAvanzado";
            this.labelFiltroAvanzado.Size = new System.Drawing.Size(36, 16);
            this.labelFiltroAvanzado.TabIndex = 15;
            this.labelFiltroAvanzado.Text = "Filtro";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(822, 571);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(72, 35);
            this.buttonBuscar.TabIndex = 16;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonVerDetalles
            // 
            this.buttonVerDetalles.Location = new System.Drawing.Point(412, 465);
            this.buttonVerDetalles.Name = "buttonVerDetalles";
            this.buttonVerDetalles.Size = new System.Drawing.Size(98, 66);
            this.buttonVerDetalles.TabIndex = 17;
            this.buttonVerDetalles.Text = "Ver detalles del articulo";
            this.buttonVerDetalles.UseVisualStyleBackColor = true;
            this.buttonVerDetalles.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVerArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 635);
            this.Controls.Add(this.buttonVerDetalles);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelFiltroAvanzado);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.labelSearchFast);
            this.Controls.Add(this.textBoxBusquedaRapida);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgregarArticulo);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.dgvVerArticulos);
            this.Controls.Add(this.pictureBoxArticulos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1249, 682);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1249, 682);
            this.Name = "FormVerArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Articulos";
            this.Load += new System.EventHandler(this.FormVerArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArticulos;
        private System.Windows.Forms.DataGridView dgvVerArticulos;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonAgregarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxBusquedaRapida;
        private System.Windows.Forms.Label labelSearchFast;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelFiltroAvanzado;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonVerDetalles;
    }
}