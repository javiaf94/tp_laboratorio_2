namespace Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnElegir = new System.Windows.Forms.Button();
            this.btnProbar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.richtxtSalas = new System.Windows.Forms.RichTextBox();
            this.statusStripInstrumento = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripInstrumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnModificar.Location = new System.Drawing.Point(671, 145);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(231, 67);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar instrumento";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAlta.Location = new System.Drawing.Point(671, 57);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(231, 69);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta de instrumento";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEliminar.Location = new System.Drawing.Point(671, 232);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(231, 65);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar instrumento";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnElegir
            // 
            this.btnElegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnElegir.Location = new System.Drawing.Point(397, 57);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(231, 69);
            this.btnElegir.TabIndex = 3;
            this.btnElegir.Text = "Elegir Instrumento";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // btnProbar
            // 
            this.btnProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnProbar.Location = new System.Drawing.Point(398, 232);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(231, 69);
            this.btnProbar.TabIndex = 4;
            this.btnProbar.Text = "Probar Instrumento";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnComprar.Location = new System.Drawing.Point(398, 145);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(231, 69);
            this.btnComprar.TabIndex = 5;
            this.btnComprar.Text = "Comprar Instrumento";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblCliente.Location = new System.Drawing.Point(475, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 22);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblEmpleado.Location = new System.Drawing.Point(744, 20);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(90, 22);
            this.lblEmpleado.TabIndex = 7;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDisponible.Location = new System.Drawing.Point(396, 307);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(187, 17);
            this.lblDisponible.TabIndex = 8;
            this.lblDisponible.Text = "Salas de prueba disponibles";
            // 
            // richtxtSalas
            // 
            this.richtxtSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.richtxtSalas.Location = new System.Drawing.Point(589, 304);
            this.richtxtSalas.Name = "richtxtSalas";
            this.richtxtSalas.Size = new System.Drawing.Size(30, 28);
            this.richtxtSalas.TabIndex = 9;
            this.richtxtSalas.Text = "3";
            // 
            // statusStripInstrumento
            // 
            this.statusStripInstrumento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel});
            this.statusStripInstrumento.Location = new System.Drawing.Point(0, 475);
            this.statusStripInstrumento.Name = "statusStripInstrumento";
            this.statusStripInstrumento.Size = new System.Drawing.Size(924, 22);
            this.statusStripInstrumento.TabIndex = 10;
            this.statusStripInstrumento.Text = "asdasdads";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(190, 17);
            this.toolStripLabel.Text = "Ningun instrumento seleccionado.";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(924, 497);
            this.Controls.Add(this.statusStripInstrumento);
            this.Controls.Add(this.richtxtSalas);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(940, 536);
            this.MinimumSize = new System.Drawing.Size(940, 536);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guitar Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_Closing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.statusStripInstrumento.ResumeLayout(false);
            this.statusStripInstrumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.RichTextBox richtxtSalas;
        private System.Windows.Forms.StatusStrip statusStripInstrumento;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
    }
}

