using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BOL;
using DAL;
using System.Data.SqlClient;


namespace GUI
{
    public partial class MantenimientoClientes : Form
    {
        Cliente c = new Cliente();
        ClienteBOL cbol;
        ClienteDAL cdal;
        public MantenimientoClientes()
        {
            InitializeComponent();
            cbol = new ClienteBOL();
            cdal = new ClienteDAL();
            Nuevo();
        }
        private void Llenar()
        {
            try
            {
                c.Cedula = Convert.ToInt32(txtCedula.Text.Trim());
                c.Nombre = txtNombre.Text.Trim();
                c.ApellidoUno = txtPApellido.Text.Trim();
                c.ApellidoDos = txtSApellido.Text.Trim();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
        }
        /// <summary>
        /// Este método permite cargar los datos almacenados previamente 
        /// hacia los objetos de la interfaz gáfica
        /// </summary>
        private void Cargar()
        {

            txtCedula.Text = Convert.ToString(c.Cedula);
            txtNombre.Text = c.Nombre;
            txtPApellido.Text = c.ApellidoUno;
            txtSApellido.Text = c.ApellidoDos;


          

        }
        /// <summary>
        /// Metodo que crea un nuevo usuario vacio a la espera de ser almacenado
        /// </summary>
        private void Nuevo()
        {
            try
            {
                c = new Cliente();
                Cargar();
            }
            catch (Exception e)
            {
                lblEstado.Text = e.Message;

            }
        }
        /// <summary>
        /// Metodo que permite guardar los datos ingresados en la interfaz, 
        /// enviando los datos a la capa bol para ser validados, si esto sucede 
        /// se enviará un mensaje de Comida almacenada con éxito
        /// </summary>
        private void Guardar()
        {
            try
            {

                Llenar();
                cbol.Guardar(c);
                Nuevo();
                lblEstado.ResetText();
                MessageBox.Show("Cliente almacenado con éxito");
                tblUs.DataSource = cdal.Lista();

            }
            catch (Exception e)
            {
                lblEstado.Text = e.Message;
            }
        }
        /// <summary>
        /// Método que elimina los datos que se encuentran en la lista,
        /// inicialmente se le pide al usuario que confirme que ese 
        /// es el usuario que desea eliminar de la base de datos.
        /// Al ser eliminado envia un mensaje que dice que el usuario
        /// ha sido eliminado con éxito
        /// </summary>
        private void Eliminar()
        {
            try
            {
                Llenar();
                if (c.ID > 0)
                {
                    string mensaje = "¿Está seguro que desea eliminar a " + c.Nombre + "?";
                    string caption = "Eliminar comidas";
                    var resultado = MessageBox.Show(mensaje, caption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        cbol.Eliminar(c);
                        Nuevo();
                        lblEstado.ResetText();
                        MessageBox.Show("Cliente eliminado con éxito");
                        tblUs.DataSource = cdal.Lista();

                    }
                }

            }
            catch (Exception e)
            {
                lblEstado.Text = e.Message;
            }
        }
        private void Lista()
        {

            tblUs.DataSource = cdal.Lista();

        }


        private void tblUs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = tblUs.SelectedRows.Count > 0 ? tblUs.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                c.ID = Convert.ToInt32(tblUs["id", row].Value);
                c.Nombre = tblUs["nombre", row].Value.ToString();
                c.ApellidoUno = tblUs["primer_apellido", row].Value.ToString();
                c.ApellidoDos = tblUs["segundo_apellido", row].Value.ToString();
                c.Cedula = Convert.ToInt32(tblUs["cedula", row].Value);
                c.Activo = Convert.ToBoolean(tblUs["activo", row].Value);
                Cargar();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void MantenimientoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¿Está seguro que desea salir del mantenimiento de clientes?";
            string caption = "Mantenimiento de Clientes";
            var resultado = MessageBox.Show(mensaje, caption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (Application.OpenForms["MAIN"] != null)
                {

                    Application.OpenForms["MAIN"].Show();
                }

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
