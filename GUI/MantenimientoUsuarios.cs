using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using Entities;
using DAL;


namespace GUI
{
    public partial class MantenimientoUsuarios : Form
    {

        UsuarioBOL usbol;
        Usuario us;
        UsuarioDAL usdao;

        public MantenimientoUsuarios()
        {
            InitializeComponent();
            //usdao = new UsuarioDAL();
            usbol = new UsuarioBOL();
            us = new Usuario();
            usdao = new UsuarioDAL();
            Nuevo();
        }

        /// <summary>
        /// Este método permite llenar los atributos al usuario, los cuales son
        ///  obtenidos de los datos ingresados por medio de la interfaz gáfica
        /// </summary>
        private void Llenar()
        {

            us.Nombre = txtNombre.Text.Trim();
            us.ApellidoUno = txtPApellido.Text.Trim();
            us.ApellidoDos = txtSApellido.Text.Trim();
            us.User = txtUsuario.Text.Trim();
            us.Password = txtContrasenna.Text.Trim();
            us.AdminSede = chkAdminSede.Checked;
            us.DueñoVehiculo = chkDVeh.Checked;
            us.Password = txtContrasenna.Text.Trim();



        }
        /// <summary>
        /// Este método permite cargar los datos almacenados previamente 
        /// hacia los objetos de la interfaz gáfica
        /// </summary>
        private void CargarUsuario()
        {
            txtNombre.Text = us.Nombre;
            txtPApellido.Text = us.ApellidoUno;
            txtSApellido.Text = us.ApellidoDos;
            txtUsuario.Text = us.User;
            txtContrasenna.Text = "";
            txtReContrasenna.Text = "";
            chkAdminSede.Checked = us.AdminSede;
            chkDVeh.Checked = us.DueñoVehiculo;

        }
        /// <summary>
        /// Metodo que crea un nuevo usuario vacio a la espera de ser almacenado
        /// </summary>
        private void Nuevo()
        {
            try
            {
                us = new Usuario();
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
                string repass = (txtReContrasenna.Text.Trim());
                Llenar();
                usbol.Guardar(us, repass);
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
                if (us.ID > 0)
                {
                    string mensaje = "¿Está seguro que desea eliminar a " + us.Nombre + "?";
                    string caption = "Form Closed";
                    var resultado = MessageBox.Show(mensaje, caption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        usbol.Eliminar(us);
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

        /// <summary>
        /// Metodo que llama a los datos de la tabla para que estos se carguen
        /// </summary>
        private void Lista()
        {

            tblUs.DataSource = usdao.Lista();
        }
        private void MantenimientoUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¿Está seguro que desea salir del mantenimiento de usuarios?";
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
        

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            Nuevo();
            tblUs.DataSource = usdao.Lista();

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            Guardar();
            tblUs.DataSource = usdao.Lista();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            Eliminar();
            tblUs.DataSource = usdao.Lista();
        }

        private void tblUs_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = tblUs.SelectedRows.Count > 0 ? tblUs.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                us.ID = Convert.ToInt32(tblUs["id", row].Value);
                us.Nombre = tblUs["nombre", row].Value.ToString();
                us.ApellidoUno = tblUs["primer_apellido", row].Value.ToString();
                us.ApellidoDos = tblUs["segundo_apellido", row].Value.ToString();
                us.User = tblUs["usuario", row].Value.ToString();
                us.Password = tblUs["contrasenna", row].Value.ToString();
                us.Activo = Convert.ToBoolean(tblUs["activo", row].Value);
                us.Admin = Convert.ToBoolean(tblUs["administrador", row].Value);
                us.AdminSede = Convert.ToBoolean(tblUs["administrador_sede", row].Value);
                us.DueñoVehiculo = Convert.ToBoolean(tblUs["dueño_veh", row].Value);
                CargarUsuario();
            }
        }

        private void MantenimientoUsuarios_Load_1(object sender, EventArgs e)
        {
            Lista();
        }
    }
}
