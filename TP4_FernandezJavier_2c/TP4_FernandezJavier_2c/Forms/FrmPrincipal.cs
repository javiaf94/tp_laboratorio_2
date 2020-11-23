using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using BibliotecaClases;
using EntidadesDAO;

namespace Forms
{
    public delegate void ActualizaLista();
    public delegate void ActualizaSeleccion(Instrumento inst);

    public partial class FrmPrincipal : Form
    {
        private delegate void Callback();        
        
        private TiendaMusical tienda;
        private Instrumento instrumentoSeleccionado;
        private int salasDisponibles;        
        private FrmProbar formProbar;
        private FrmInstrumento formInstrumento;        

        private List<Thread> hilos;
        private System.Windows.Forms.Timer timer;       

        public FrmPrincipal()
        {
            InitializeComponent();
            //inicializo la tienda y leo la db para traer los instrumentos.
            this.tienda = new TiendaMusical();
            this.tienda.Instrumentos = InstrumentoDAO.LeerInstrumentos();                     
            //simulo clientes utilizando las salas de prueba. El simulador se ejecutara
            //Aleatoriamente según el tick del timer.
            this.timer = new System.Windows.Forms.Timer();            
            this.timer.Tick += new EventHandler(this.SimuladorClientes);
            this.timer.Interval = new Random().Next(1000, 5000);
            this.timer.Start();
        }

        //inicializo las salas disponibles.
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Inicializo la lista de hilos asignandole su tamaño
            this.hilos = new List<Thread>(4) {null, null, null, null};
            this.salasDisponibles = 4;
            this.richtxtSalas.Text = this.salasDisponibles.ToString();
        }


        /// <summary>
        /// inicializa el form que permite modificar un instrumento, subscribiendo al evento
        /// lanzado por las modificaciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.formInstrumento = new FrmInstrumento(this.tienda);
            //deshabilito los botones que no corresponden a la instancia del forminstrumentos
            this.formInstrumento.btnAlta.Enabled = false;
            this.formInstrumento.btnSeleccionar.Enabled = false;
            this.formInstrumento.btnEliminar.Enabled = false;
            
            this.formInstrumento.ModificacionInstrumentos += ManejadorActualizaLista;
            this.formInstrumento.ShowDialog();
        }

        /// <summary>
        /// Inicializa el formulario que permite el alta de un nuevo instrumento, subscribiendo
        /// al evento que lanza el alta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.formInstrumento = new FrmInstrumento();
            //deshabilito los controles que no corresponden a la instancia del forminstrumentos
            this.formInstrumento.btnModificar.Enabled = false;
            this.formInstrumento.btnSeleccionar.Enabled = false;
            this.formInstrumento.btnEliminar.Enabled = false;            
            this.formInstrumento.ModificacionInstrumentos += ManejadorActualizaLista;
            this.formInstrumento.ShowDialog();
        }

        /// <summary>
        /// Inicializa el formulario que permite borrar un instrumento, subscribiendo
        /// al evento que lanza el alta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.formInstrumento = new FrmInstrumento(this.tienda);
            //deshabilito los controles que no corresponden a la instancia del forminstrumentos
            this.formInstrumento.cmbInstrumento.Enabled = false;
            this.formInstrumento.txtMarca.Enabled = false;
            this.formInstrumento.txtModelo.Enabled = false;
            this.formInstrumento.txtPrecio.Enabled = false;
            this.formInstrumento.txtSerie.Enabled = false;
            this.formInstrumento.cmbTipo.Enabled = false;
            //deshabilito los botones que no corresponden a la instancia del forminstrumentos
            this.formInstrumento.btnAlta.Enabled = false;
            this.formInstrumento.btnModificar.Enabled = false;
            this.formInstrumento.btnSeleccionar.Enabled = false;

            this.formInstrumento.ModificacionInstrumentos += ManejadorActualizaLista;
            this.formInstrumento.ShowDialog();
        }

        /// <summary>
        /// Inicializa el formulario que permite la seleccion de un instrumento, subscribiendo
        /// al evento que lanza la eleccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnElegir_Click(object sender, EventArgs e)
        {
            this.formInstrumento = new FrmInstrumento(this.tienda);
            //deshabilito los controles que no corresponden a la instancia del forminstrumentos
            this.formInstrumento.cmbInstrumento.Enabled = false;
            this.formInstrumento.txtMarca.Enabled = false;
            this.formInstrumento.txtModelo.Enabled = false;
            this.formInstrumento.txtPrecio.Enabled = false;
            this.formInstrumento.txtSerie.Enabled = false;
            this.formInstrumento.cmbTipo.Enabled = false;
            //deshabilito los botones que no corresponden a la instancia del forminstrumentos
            this.formInstrumento.btnAlta.Enabled = false;
            this.formInstrumento.btnModificar.Enabled = false;
            this.formInstrumento.btnEliminar.Enabled = false;

            this.formInstrumento.SeleccionInstrumento += ManejadorSeleccionInstrumento;
            this.formInstrumento.ShowDialog();
        }

        /// <summary>
        /// Verifica que se haya seleccionado un instrumento. Solicita confirmación antes de realizar
        /// la venta del instrumento y su eliminacion de la DB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(this.instrumentoSeleccionado, null))
            {
                MessageBox.Show("Debe elegir un instrumento primero");
            }
            else
            {
                DialogResult comprar = MessageBox.Show($"Desea comprar el instrumento: {this.instrumentoSeleccionado.ToString()}", "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (comprar == DialogResult.Yes)
                {
                    try
                    {
                        //Vendo el instrumento seleccionado y serializo.
                        this.tienda.Vender(this.instrumentoSeleccionado, "ventas.xml");

                        if(this.instrumentoSeleccionado is Bajo)
                        {
                            InstrumentoDAO.EliminarBajo(this.instrumentoSeleccionado.NumSerie);
                        }
                        else
                        {
                            InstrumentoDAO.EliminarGuitarra(this.instrumentoSeleccionado.NumSerie);
                        }

                        MessageBox.Show("Se efectuó la compra");
                        //Elimino el instrumento seleccionado.
                        this.toolStripLabel.Text = "Ningún instrumento seleccionado";
                        this.instrumentoSeleccionado = null;
                        //Vuelvo a leer la base de datos para que no muestre el eliminado.
                        this.ManejadorActualizaLista();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Verifica que haya salas disponibles y que se haya seleccionado un instrumento
        /// antes de mostrar una instancia del FormProbar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProbar_Click(object sender, EventArgs e)
        {
            if (!object.ReferenceEquals(this.instrumentoSeleccionado, null))
            {
                if (salasDisponibles > 0)
                {
                    this.salasDisponibles--; //ocupo una sala
                    this.richtxtSalas.Text = this.salasDisponibles.ToString(); 
                    this.formProbar = new FrmProbar(this.instrumentoSeleccionado);
                    this.formProbar.ShowDialog();
                    this.salasDisponibles++; //libero la sala.
                    this.richtxtSalas.Text = this.salasDisponibles.ToString();
                }
                else
                {
                    MessageBox.Show("No hay salas disponibles en este momento");
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un instrumento primero");
            }
        }

        /// <summary>
        /// recorré los hilos, lanzando el metodo usar sala, y reduciendo en 1 las salas disponibles
        /// por cada hilo lanzado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SimuladorClientes(Object sender, EventArgs e)
        {
            //cambio el intervalo para hacerlo mas aleatorio  y recorro los hilos
            this.timer.Interval = new Random().Next(1000, 5000); 
            for (int i = 0; i< this.hilos.Count; i++)
            {
                if (this.hilos[i] == null) //si no fue instanciado creo llamando a usar sala
                {
                    Thread hilo = new Thread(UsarSala);
                    this.hilos[i] = hilo;
                    this.salasDisponibles--;
                    this.richtxtSalas.Text = this.salasDisponibles.ToString();
                    hilo.Start();
                }
                else if (!this.hilos[i].IsAlive && this.salasDisponibles > 0)
                {
                    //si no está activo y hay salas disponibles lanzo el hilo nuevamente.
                    Thread hilo = new Thread(UsarSala);
                    this.hilos[i] = hilo;
                    this.salasDisponibles--;
                    this.richtxtSalas.Text = this.salasDisponibles.ToString();
                    hilo.Start();
                }
            }
        }


        /// <summary>
        /// Duerme el hilo simulando ocupar una sala, una vez terminado aumenta en una las
        /// salas disponibles.
        /// </summary>
        private void UsarSala()
        {
            if (this.richtxtSalas.InvokeRequired)
            {
                Thread.Sleep(new Random().Next(1000, 3000));
                Callback d = new Callback(this.UsarSala);
                this.Invoke(d);
            }
            else
            {
                this.salasDisponibles++;
                this.richtxtSalas.Text = this.salasDisponibles.ToString();                
            }
        }

        /// <summary>
        /// Actgualiza la lista de instrumentos leyendola de la DB.
        /// </summary>
        private void ManejadorActualizaLista()
        {
            this.tienda.Instrumentos = InstrumentoDAO.LeerInstrumentos();
        }

        /// <summary>
        /// Muestra en el label inferior el instrumento seleccionado para su prueba o compra
        /// </summary>
        /// <param name="inst"></param>
        private void ManejadorSeleccionInstrumento(Instrumento inst)
        {
            this.instrumentoSeleccionado = inst;
            this.toolStripLabel.Text = this.instrumentoSeleccionado.ToString();
        }

        /// <summary>
        /// Verifica si algún hilo se encuentra vivo y lo cierra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Closing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread thread in this.hilos)
            {
                if(thread != null && thread.IsAlive)
                {
                    thread.Abort();
                }
            } 
        }

    }
}











