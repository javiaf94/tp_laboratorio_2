namespace Forms
{
    partial class FrmInstrumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstrumento));
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblInstrumento = new System.Windows.Forms.Label();
            this.cmbInstrumento = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listInstrumentos = new System.Windows.Forms.ListBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMarca.Enabled = false;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblMarca.Location = new System.Drawing.Point(27, 111);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(126, 25);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:        ";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtMarca.Location = new System.Drawing.Point(180, 108);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(148, 31);
            this.txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtModelo.Location = new System.Drawing.Point(180, 158);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(148, 31);
            this.txtModelo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(27, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo:      ";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtSerie.Location = new System.Drawing.Point(180, 206);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(148, 31);
            this.txtSerie.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPrecio.Enabled = false;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblPrecio.Location = new System.Drawing.Point(27, 252);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(127, 25);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:        ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtPrecio.Location = new System.Drawing.Point(180, 249);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(148, 31);
            this.txtPrecio.TabIndex = 8;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSerie.Enabled = false;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblSerie.Location = new System.Drawing.Point(27, 206);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(126, 25);
            this.lblSerie.TabIndex = 7;
            this.lblSerie.Text = "Nro Serie:   ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTipo.Enabled = false;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTipo.Location = new System.Drawing.Point(28, 294);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(126, 25);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo:           ";
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblInstrumento.Location = new System.Drawing.Point(27, 65);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(130, 25);
            this.lblInstrumento.TabIndex = 13;
            this.lblInstrumento.Text = "Instrumento:";
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbInstrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.Items.AddRange(new object[] {
            "Guitarra",
            "Bajo"});
            this.cmbInstrumento.Location = new System.Drawing.Point(180, 62);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(148, 33);
            this.cmbInstrumento.TabIndex = 14;
            this.cmbInstrumento.SelectedIndexChanged += new System.EventHandler(this.cmbInstrumento_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(180, 291);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(148, 33);
            this.cmbTipo.TabIndex = 17;
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnAlta.Location = new System.Drawing.Point(423, 22);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(148, 52);
            this.btnAlta.TabIndex = 18;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnSalir.Location = new System.Drawing.Point(423, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 52);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listInstrumentos
            // 
            this.listInstrumentos.FormattingEnabled = true;
            this.listInstrumentos.Location = new System.Drawing.Point(647, 12);
            this.listInstrumentos.Name = "listInstrumentos";
            this.listInstrumentos.Size = new System.Drawing.Size(140, 355);
            this.listInstrumentos.TabIndex = 22;
            this.listInstrumentos.SelectedIndexChanged += new System.EventHandler(this.listInstrumentos_SelectedIndexChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnSeleccionar.Location = new System.Drawing.Point(423, 241);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(148, 52);
            this.btnSeleccionar.TabIndex = 23;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnModificar.Location = new System.Drawing.Point(423, 94);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 52);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnEliminar.Location = new System.Drawing.Point(423, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 52);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 383);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.listInstrumentos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbInstrumento);
            this.Controls.Add(this.lblInstrumento);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInstrumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblMarca;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label lblPrecio;
        protected System.Windows.Forms.Label lblSerie;
        protected System.Windows.Forms.Label lblTipo;
        protected System.Windows.Forms.Label lblInstrumento;
        private System.Windows.Forms.ListBox listInstrumentos;
        internal System.Windows.Forms.TextBox txtMarca;
        internal System.Windows.Forms.TextBox txtModelo;
        internal System.Windows.Forms.TextBox txtSerie;
        internal System.Windows.Forms.TextBox txtPrecio;
        internal System.Windows.Forms.ComboBox cmbInstrumento;
        internal System.Windows.Forms.ComboBox cmbTipo;
        internal System.Windows.Forms.Button btnAlta;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnSeleccionar;
        internal System.Windows.Forms.Button btnModificar;
        internal System.Windows.Forms.Button btnEliminar;
    }
}