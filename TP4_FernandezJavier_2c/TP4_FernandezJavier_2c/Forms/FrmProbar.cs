using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using BibliotecaClases;

namespace Forms
{
    public partial class FrmProbar : Form
    {
        private SoundPlayer player;
        
        public FrmProbar(Instrumento instrumento)
        {
            InitializeComponent();
            if(instrumento is Bajo)
            {
                Bajo bajo = (Bajo)instrumento;
                switch (bajo.Tipo)
                {
                    case Bajo.ETipoBajo.Activo:
                        this.player = new SoundPlayer("Sample4.wav");
                        break;
                    case Bajo.ETipoBajo.Pasivo:
                        this.player = new SoundPlayer("Sample3.wav");
                        break;
                }
            }
            if (instrumento is Guitarra)
            {
                Guitarra guitarra = (Guitarra)instrumento;
                switch (guitarra.Tipo)
                {
                    case Guitarra.ETipoGuitarra.Electrica:
                        this.player = new SoundPlayer("Sample.wav");                        
                        break;
                    case Guitarra.ETipoGuitarra.Acustica:
                        this.player = new SoundPlayer("Sample2.wav");
                        break;
                }
            }
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            this.player.Play();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.player != null)
            {
                this.player.Stop();
                this.player.Dispose();
            }
            this.Close();
        }
    }
}
