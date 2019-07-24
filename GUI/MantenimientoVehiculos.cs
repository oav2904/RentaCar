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
    public partial class MantenimientoVehiculos : Form
    {
        Vehiculo v = new Vehiculo();
        VehiculoBOL vbol;
        VehiculoDAL vdal;
        public MantenimientoVehiculos()
        {
            vbol = new VehiculoBOL();
            vdal = new VehiculoDAL();
            InitializeComponent();
        }
        /// <summary>
        /// Este método permite llenar los atributos al usuario, los cuales son
        ///  obtenidos de los datos ingresados por medio de la interfaz gáfica
        /// </summary>
        private void Llenar()
        {
            try
            {


                v.User = cmbUser.SelectedIndex+1;
                v.NumPlaca = txtNumPlaca.Text.Trim();
                v.Color = txtColor.Text.Trim();
                v.Marca = txtMarca.Text.Trim();
                v.Modelo = txtModelo.Text.Trim();
                v.Año = Convert.ToInt32(cbanno.SelectedItem);
                v.Tipo = Convert.ToString(cmbTipo.SelectedItem);
                v.CostoDia = Convert.ToInt32(txtCosto.Text.Trim());




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
            cmbUser.SelectedItem = v.User;
            txtNumPlaca.Text = v.NumPlaca;
            txtColor.Text = v.Color;
            txtMarca.Text = v.Marca;
            txtModelo.Text = v.Modelo;
            cbanno.SelectedItem  = v.Año;
            cmbTipo.SelectedItem = v.Tipo ;
            txtCosto.Text = Convert.ToString(v.CostoDia);

        }
        /// <summary>
        /// Metodo que crea un nuevo usuario vacio a la espera de ser almacenado
        /// </summary>
        private void Nuevo()
        {
            try
            {
                v = new Vehiculo();
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
                vbol.Guardar(v);
                Nuevo();
                lblEstado.ResetText();
                MessageBox.Show("Vehiculo almacenado con éxito");
                tbVehiculos.DataSource = vdal.Lista();

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
                if (v.ID > 0)
                {
                    string mensaje = "¿Está seguro que desea eliminar a " + v.NumPlaca + "?";
                    string caption = "Eliminar Vehiculos";
                    var resultado = MessageBox.Show(mensaje, caption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        vbol.Eliminar(v);
                        Nuevo();
                        lblEstado.ResetText();
                        MessageBox.Show("Vehiculo eliminado con éxito");
                        tbVehiculos.DataSource = vdal.Lista();

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

            tbVehiculos.DataSource = vdal.Lista();
            cmbUser.DataSource = vdal.ObtenerUser();
            cmbUser.DisplayMember = "User";
            cmbUser.ValueMember = "ID";

        }
        private void MantenimientoVehiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¿Está seguro que desea salir del mantenimiento de vehiculos?";
            string caption = "Mantenimiento de Vehiculos";
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void MantenimientoVehiculos_Load(object sender, EventArgs e)
        {
            Lista();
        }

    
        private void tbVehiculos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = tbVehiculos.SelectedRows.Count > 0 ? tbVehiculos.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                v.ID = Convert.ToInt32(tbVehiculos["id", row].Value);
                v.User = Convert.ToInt32(tbVehiculos["dueño", row].Value);
                v.NumPlaca = tbVehiculos["num_placa", row].Value.ToString();
                v.Color = tbVehiculos["color", row].Value.ToString();
                v.Modelo = tbVehiculos["modelo", row].Value.ToString();
                v.Marca = tbVehiculos["marca", row].Value.ToString();
                v.Año = Convert.ToInt32(tbVehiculos["anno", row].Value);
                v.Tipo = tbVehiculos["tipo", row].Value.ToString();
                v.CostoDia = Convert.ToInt32(tbVehiculos["costo_dia", row].Value);
                v.Activo = Convert.ToBoolean(tbVehiculos["activo", row].Value);
                Cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
