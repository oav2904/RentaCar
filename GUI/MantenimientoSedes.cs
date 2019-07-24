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

namespace GUI
{
    public partial class MantenimientoSedes : Form
    {
        Sede s = new Sede();
        SedeBOL sebol;
        SedeDAL sedal;

        public MantenimientoSedes()
        {
            InitializeComponent();
            sebol = new SedeBOL();
            sedal = new SedeDAL();
        }
        /// <summary>
        /// Este método permite llenar los atributos al usuario, los cuales son
        ///  obtenidos de los datos ingresados por medio de la interfaz gáfica
        /// </summary>
        private void Llenar()
        {

            s.Nombre = txtNombre.Text.Trim();
            s.Ciudad = txtPApellido.Text.Trim();
            s.Canton = txtSApellido.Text.Trim();
            s.Provincia = txtUsuario.Text.Trim();
            s.Pais = txtContrasenna.Text.Trim();



        }
        /// <summary>
        /// Este método permite cargar los datos almacenados previamente 
        /// hacia los objetos de la interfaz gáfica
        /// </summary>
        private void CargarUsuario()
        {
            txtNombre.Text = s.Nombre;
            txtPApellido.Text = s.Ciudad;
            txtSApellido.Text = s.Canton;
            txtUsuario.Text = s.Provincia;
            txtContrasenna.Text = s.Pais;
        }
        /// <summary>
        /// Metodo que crea un nuevo usuario vacio a la espera de ser almacenado
        /// </summary>
        private void Nuevo()
        {
            try
            {
                s = new Sede();
                CargarUsuario();
            }
            catch (Exception e)
            {
                lblEstado.Text = e.Message;

            }
        }
        /// <summary>
        /// Metodo que permite guardar los datos ingresados en la interfaz, 
        /// enviando los datos a la capa bol para ser validados, si esto sucede 
        /// se enviará un mensaje de Usuario almacenado con éxito
        /// </summary>
        private void Guardar()
        {
            try
            {
                Llenar();
                sebol.Guardar(s);
                Nuevo();
                lblEstado.ResetText();
                MessageBox.Show("Usuario almacenado con éxito");

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
                if (s.ID > 0)
                {
                    string mensaje = "¿Está seguro que desea eliminar a " + s.Nombre + "?";
                    string caption = "Form Closed";
                    var resultado = MessageBox.Show(mensaje, caption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        sebol.Eliminar(s);
                        Nuevo();
                        lblEstado.ResetText();
                        MessageBox.Show("Usuario eliminado con éxito");


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
            tblUs.DataSource = sedal.Lista();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            tblUs.DataSource = sedal.Lista();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            tblUs.DataSource = sedal.Lista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            tblUs.DataSource = sedal.Lista();
        }

        private void MantenimientoSedes_Load(object sender, EventArgs e)
        {
            Lista();
        }

        private void MantenimientoSedes_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¿Está seguro que desea salir del mantenimiento de sedes?";
            string caption = "Mantenimiento de Usuarios";
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

        private void tblUs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = tblUs.SelectedRows.Count > 0 ? tblUs.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                s.ID = Convert.ToInt32(tblUs["id", row].Value);
                s.Nombre = tblUs["nombre", row].Value.ToString();
                s.Ciudad = tblUs["cuidad", row].Value.ToString();
                s.Canton = tblUs["canton", row].Value.ToString();
                s.Provincia = tblUs["provincia", row].Value.ToString();
                s.Pais = tblUs["pais", row].Value.ToString();
                s.Activo = Convert.ToBoolean(tblUs["activo", row].Value);
                CargarUsuario();

            }
        }
    }
}
