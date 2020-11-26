using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BibliotecaClases;
using Excepciones;
using EntidadesDAO;

namespace Forms
{

    public partial class FrmInstrumento : Form
    {
        public event ActualizaLista ModificacionInstrumentos;
        public event ActualizaSeleccion SeleccionInstrumento;

        private TiendaMusical tienda;

        /// <summary>
        /// Instancia el formulario, mostrando los instrumentos disponibles.
        /// </summary>
        /// <param name="t"></param>
        public FrmInstrumento(TiendaMusical t)
        {
            InitializeComponent();
            this.tienda = t;
            this.listInstrumentos.DataSource = this.tienda.Instrumentos;
            //Verifico que la lista de instrumentos no esté vacía. Para que el programa no se cierre.
            if(this.listInstrumentos.Items.Count != 0)
                this.listInstrumentos.DisplayMember = this.listInstrumentos.SelectedItem.ToString();
        }

        /// <summary>
        /// Instancia el formulario, ocultando la lista de instrumentos (utilizado para altas)
        /// </summary>
        public FrmInstrumento()
        {
            InitializeComponent();
            //Este formulario oculta la lista de instrumentos
            this.Size = new Size(649, 420);
            this.cmbInstrumento.SelectedIndex = 0;
            this.listInstrumentos.Enabled = false;
        }
        
        /// <summary>
        /// Al elegir un tipo de instrumento del combo muestra por pantalla el tipo correcto de instrumento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbInstrumento.SelectedItem.ToString() == "Guitarra")
            {               
                this.cmbTipo.DataSource = Enum.GetValues(typeof(Guitarra.ETipoGuitarra));                    
            }
                    
            else if (cmbInstrumento.SelectedItem.ToString() == "Bajo")
            {
                this.cmbTipo.DataSource = Enum.GetValues(typeof(Bajo.ETipoBajo));
            }
        }
            

        /// <summary>
        /// Valida que los datos sean validos para un instrumento.
        /// </summary>
        /// <returns></returns>
        private bool ValidarDatos()
        {
            float precio;            
            if (!string.IsNullOrWhiteSpace(this.txtSerie.Text) && 
                !string.IsNullOrWhiteSpace(this.txtMarca.Text) &&
                !string.IsNullOrWhiteSpace(this.txtModelo.Text) &&
                float.TryParse(this.txtPrecio.Text, out precio))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Guarda el alta de un nuevo instrumento en la base de datos, validando los datos
        /// y arrojando error de encontrarse repetido o haber algún dato erroneo.
        /// Dispara un evento que avisa de la modificación al form principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            if(this.ValidarDatos())
            {
                //Leo los datos del instrumento
                float precio = float.Parse(this.txtPrecio.Text);                 
                if(this.cmbInstrumento.SelectedIndex == 0) 
                {
                    Guitarra.ETipoGuitarra tipo;
                    Enum.TryParse<Guitarra.ETipoGuitarra>(this.cmbTipo.SelectedValue.ToString(), out tipo);                    
                    try
                    {
                        //Guardo la guitarra en la base y disparo el evento.
                        Guitarra g = new Guitarra(this.txtSerie.Text, this.txtMarca.Text, this.txtModelo.Text, precio, tipo);                        
                        InstrumentoDAO.Guardar(g);
                        this.ModificacionInstrumentos.Invoke();
                        MessageBox.Show("Se dio el alta con exito");
                        this.Close();
                    }
                    catch(InstrumentoRepetidoException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if(this.cmbInstrumento.SelectedIndex == 1)
                {                    
                    Bajo.ETipoBajo tipo;
                    Enum.TryParse<Bajo.ETipoBajo>(this.cmbTipo.SelectedValue.ToString(), out tipo);
                    try
                    {
                        //Guardo el Bajo en la base y disparo el evento.
                        Bajo b = new Bajo(this.txtSerie.Text, this.txtMarca.Text, this.txtModelo.Text, precio, tipo);                        
                        InstrumentoDAO.Guardar(b);
                        this.ModificacionInstrumentos.Invoke();
                        MessageBox.Show("Se dio el alta con exito");
                        this.Close();
                    }
                    catch (InstrumentoRepetidoException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else //si la validacion falla
            {
                MessageBox.Show("Los datos ingresados no son correctos");
            }
        }

        /// <summary>
        /// Cierra el formulario, volviendo a la pantalla inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se guardaron cambios.");
            this.Close();
        }

        /// <summary>
        /// Actualiza por pantalla los datos del instrumento seleccionado de la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listInstrumentos_SelectedIndexChanged(object sender, EventArgs e)
        {

            Instrumento seleccion = (Instrumento)this.listInstrumentos.SelectedItem;
            this.txtMarca.Text = seleccion.Marca;
            this.txtModelo.Text = seleccion.Modelo;
            this.txtPrecio.Text = seleccion.Precio.ToString();
            this.txtSerie.Text = seleccion.NumSerie;
            //Selecciona el tipo según el tipo de instrumento.
            if (seleccion is Guitarra)
            {
                Guitarra seleccionGuitarra = (Guitarra)seleccion;
                this.cmbInstrumento.SelectedIndex = 0;
                this.cmbTipo.DataSource = Enum.GetValues(typeof(Guitarra.ETipoGuitarra));
                switch (seleccionGuitarra.Tipo)
                {
                    case Guitarra.ETipoGuitarra.Electrica:
                        this.cmbTipo.SelectedIndex = 0;
                        break;

                    case Guitarra.ETipoGuitarra.Acustica:
                        this.cmbTipo.SelectedIndex = 1;                        
                        break;
                }
            }
            else
            {
                Bajo seleccionBajo = (Bajo)seleccion;
                this.cmbInstrumento.SelectedIndex = 1;
                this.cmbTipo.DataSource = Enum.GetValues(typeof(Bajo.ETipoBajo));
                switch (seleccionBajo.Tipo)
                {
                    case Bajo.ETipoBajo.Activo:
                        this.cmbTipo.SelectedIndex = 0;
                        break;
                    case Bajo.ETipoBajo.Pasivo:
                        this.cmbTipo.SelectedIndex = 1;
                        break;
                }
            }
        }

        /// <summary>
        /// Elige el instrumento que se desea probar o comprar, y lo envia al frm principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(this.SeleccionInstrumento != null)
            {
                Instrumento seleccion = (Instrumento)this.listInstrumentos.SelectedItem;
                this.SeleccionInstrumento.Invoke(seleccion);
            }
            this.Close();
        }

        /// <summary>
        /// Modifica el instrumento seleccionado con los valores ingresados, lo guarda en la DB
        /// y avisa al FormPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.ValidarDatos())
            {
                float precio = float.Parse(this.txtPrecio.Text);

                if (this.cmbInstrumento.SelectedIndex == 0)
                {
                    Guitarra.ETipoGuitarra tipo;
                    Enum.TryParse<Guitarra.ETipoGuitarra>(this.cmbTipo.SelectedValue.ToString(), out tipo);

                    Guitarra g = new Guitarra(this.txtSerie.Text, this.txtMarca.Text, this.txtModelo.Text, precio, tipo);
                    try
                    {
                        InstrumentoDAO.Modificar(g);
                        this.ModificacionInstrumentos.Invoke();
                        MessageBox.Show("Se modificó con exito");
                    }
                    catch(DatabaseException ex)
                    {
                        MessageBox.Show(ex.Message + " Por favor intentarlo nuevamente", "Error en la modificación");
                    }
                    this.Close();


                }
                else if (this.cmbInstrumento.SelectedIndex == 1)
                {
                    Bajo.ETipoBajo tipo;
                    Enum.TryParse<Bajo.ETipoBajo>(this.cmbTipo.SelectedValue.ToString(), out tipo);

                    Bajo b = new Bajo(this.txtSerie.Text, this.txtMarca.Text, this.txtModelo.Text, precio, tipo);
                    try
                    {
                        InstrumentoDAO.Modificar(b);
                        this.ModificacionInstrumentos();
                        MessageBox.Show("Se modificó con exito");
                    }
                    catch(DatabaseException ex)
                    {
                        MessageBox.Show(ex.Message + " Por favor intentarlo nuevamente", "Error en la modificación");
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son correctos");
            }
        }

        /// <summary>
        /// Elimina el instrumento, avisando si pudo hacerlo correctamente, e informando mediante
        /// el evento ModificacionInstrumento al FormPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listInstrumentos.SelectedValue is Guitarra && InstrumentoDAO.EliminarGuitarra(this.txtSerie.Text) == 1)
                    MessageBox.Show("Se elimino correctamente la Guitarra");
            
                else if(this.listInstrumentos.SelectedValue is Bajo && InstrumentoDAO.EliminarBajo(this.txtSerie.Text) == 1)
                    MessageBox.Show("Se elimino correctamente el Bajo");
                this.ModificacionInstrumentos.Invoke();
            }
            catch(DatabaseException ex)
            {
                MessageBox.Show(ex.Message + " Por favor intente nuevamente", "Error al eliminar");
            }
            this.Close();
        }
    }
}




                    
            



