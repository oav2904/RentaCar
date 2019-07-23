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


namespace GUI
{
    public partial class MantenimientoUsuarios : Form
    {
       
        UsuarioBOL usbol;
        Usuario us;

        public MantenimientoUsuarios()
        {
            InitializeComponent();
            //usdao = new UsuarioDAL();
            usbol = new UsuarioBOL();
            us = new Usuario();
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
            txtCodigo.Text = us.Codigo;
            txtCedula.Text = Convert.ToString(us.Cedula);
            txtUsuario.Text = us.Usuarios;
            txtContrasenna.Text = "";
            txtReContrasenna.Text = "";

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
                usbol.guardar(us, repass);
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
                        usbol.eliminar(us);
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

            tblUs.DataSource = usdao.ListaUsuarios();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            tblUs.DataSource = usdao.ListaUsuarios();

        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            Lista();
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
        private void tblUs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = tblUs.SelectedRows.Count > 0 ? tblUs.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                us.ID = Convert.ToInt32(tblUs["id_usuario", row].Value);
                us.Codigo = tblUs["codigo", row].Value.ToString();
                us.Nombre = tblUs["nombre", row].Value.ToString();
                us.ApellidoUno = tblUs["papellido", row].Value.ToString();
                us.ApellidoDos = tblUs["sapellido", row].Value.ToString();
                us.Cedula = Convert.ToInt32(tblUs["cedula", row].Value.ToString());
                us.Usuarios = tblUs["usuario", row].Value.ToString();
                us.Password = tblUs["contrasenna", row].Value.ToString();
                us.Activo = Convert.ToBoolean(tblUs["activo", row].Value);
                us.Admin = Convert.ToBoolean(tblUs["admin", row].Value);
                CargarUsuario();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            tblUs.DataSource = usdao.ListaUsuarios();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            tblUs.DataSource = usdao.ListaUsuarios();
        }

    }
}
