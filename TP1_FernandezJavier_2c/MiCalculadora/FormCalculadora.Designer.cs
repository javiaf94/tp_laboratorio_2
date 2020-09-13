namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.textNumero1 = new System.Windows.Forms.TextBox();
            this.textNumero2 = new System.Windows.Forms.TextBox();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonConvertirEnBinario = new System.Windows.Forms.Button();
            this.buttonConvertirEnDecimal = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNumero1
            // 
            this.textNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.textNumero1.Location = new System.Drawing.Point(27, 72);
            this.textNumero1.Multiline = true;
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Size = new System.Drawing.Size(161, 41);
            this.textNumero1.TabIndex = 0;
            this.textNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNumero2
            // 
            this.textNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.textNumero2.Location = new System.Drawing.Point(305, 72);
            this.textNumero2.Multiline = true;
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(163, 41);
            this.textNumero2.TabIndex = 2;
            this.textNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperador.Location = new System.Drawing.Point(210, 72);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(70, 41);
            this.comboBoxOperador.TabIndex = 1;
            // 
            // buttonOperar
            // 
            this.buttonOperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOperar.Location = new System.Drawing.Point(27, 148);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(140, 40);
            this.buttonOperar.TabIndex = 3;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrar.Location = new System.Drawing.Point(330, 148);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(138, 40);
            this.buttonCerrar.TabIndex = 5;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar.Location = new System.Drawing.Point(177, 148);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(140, 40);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonConvertirEnBinario
            // 
            this.buttonConvertirEnBinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConvertirEnBinario.Location = new System.Drawing.Point(27, 206);
            this.buttonConvertirEnBinario.Name = "buttonConvertirEnBinario";
            this.buttonConvertirEnBinario.Size = new System.Drawing.Size(222, 40);
            this.buttonConvertirEnBinario.TabIndex = 6;
            this.buttonConvertirEnBinario.Text = "Convertir a Binario";
            this.buttonConvertirEnBinario.UseVisualStyleBackColor = true;
            this.buttonConvertirEnBinario.Click += new System.EventHandler(this.buttonConvertirEnBinario_Click);
            // 
            // buttonConvertirEnDecimal
            // 
            this.buttonConvertirEnDecimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConvertirEnDecimal.Location = new System.Drawing.Point(255, 206);
            this.buttonConvertirEnDecimal.Name = "buttonConvertirEnDecimal";
            this.buttonConvertirEnDecimal.Size = new System.Drawing.Size(213, 40);
            this.buttonConvertirEnDecimal.TabIndex = 7;
            this.buttonConvertirEnDecimal.Text = "Convertir a Decimal";
            this.buttonConvertirEnDecimal.UseVisualStyleBackColor = true;
            this.buttonConvertirEnDecimal.Click += new System.EventHandler(this.buttonConvertirEnDecimal_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.labelResultado.Location = new System.Drawing.Point(27, 23);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(441, 34);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = " ";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 260);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonConvertirEnDecimal);
            this.Controls.Add(this.buttonConvertirEnBinario);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Javier Fernandez del curso 2°C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumero1;
        private System.Windows.Forms.TextBox textNumero2;
        private System.Windows.Forms.ComboBox comboBoxOperador;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonConvertirEnBinario;
        private System.Windows.Forms.Button buttonConvertirEnDecimal;
        private System.Windows.Forms.Label labelResultado;
    }
}

