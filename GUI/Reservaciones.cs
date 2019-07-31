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
using DAL;
using BOL;

namespace GUI
{
    public partial class Reservaciones : Form
    {
        Reservacion r = new Reservacion();
        ReservacionBOL rbol;
        ReservacionDAL rdal;
        public Reservaciones()
        {
            rbol = new ReservacionBOL();
            rdal = new ReservacionDAL();
            InitializeComponent();
            CargarVehiculos();
            Nuevo();
        }
        /// <summary>
        /// Este método permite llenar los atributos al usuario, los cuales son
        ///  obtenidos de los datos ingresados por medio de la interfaz gáfica
        /// </summary>
        private void Llenar()
        {

            r.Cliente = cmbUsers.SelectedIndex+1;
            r.Vehiculos = cmbMarca.SelectedIndex+1;
            r.FechaInicio = Convert.ToDateTime(txtRecogida.Text.Trim());
            r.FechaFinal = Convert.ToDateTime(txtDevolucion.Text.Trim());
            r.Costo = Convert.ToInt32(txtCosto.Text.Trim());
        }
       
        /// <summary>
        /// Metodo que crea un nuevo usuario vacio a la espera de ser almacenado
        /// </summary>
        private void Nuevo()
        {
            try
            {
                r = new Reservacion();
            }
            catch (Exception e)
            {
               

            }
        }

        private void Guardar()
        {
            try
            {
                
                Llenar();
                rbol.Guardar(r);
                Nuevo();
          
                MessageBox.Show("Reservación creada con éxito");

            }
            catch (Exception e)
            {
              
            }
        }

        private void Lista()
        {

            dataFacturas.DataSource = rdal.Lista();
        }

        private void Facturar_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            int id=0;
            double subtT;
            double iva;
            double precio = 0;
            double total = 0;
            foreach (DataGridViewRow row in dataFacturas.Rows)
            {
                precio = Convert.ToDouble(row.Cells["costo"].Value);
                id = Convert.ToInt32(row.Cells["id"].Value);

            }
            
            subtT = precio;
            iva = (subtT * 13) / 100;
            total = iva + subtT;
            txtSubTotal.Text = Convert.ToString(subtT);
            txtIVA.Text = Convert.ToString(iva);
            txtTotal.Text = Convert.ToString(total);
            Lista();
            rbol.Facturar(id);
        }


        private void CargarVehiculos()
        {
            try
            {
                cmbUsers.DataSource = rdal.ObtenerUser();
                cmbUsers.DisplayMember = "Nombre";
                cmbUsers.ValueMember = "ID";
                cmbMarca.DataSource = rdal.ObtenerVehiculo();
                cmbMarca.DisplayMember = "Marca";
                cmbMarca.ValueMember = "Marca";
                string m = Convert.ToString(cmbMarca.SelectedValue);
                cmbModelo.DataSource = rdal.ObtenerModelo(m);
                cmbModelo.DisplayMember = "Modelo";
                cmbModelo.ValueMember = "Modelo";
                string M = Convert.ToString(cmbModelo.SelectedValue);
                txtCosto.Text = Convert.ToString(rdal.ObtenerCosto(M));
                rdal.ObtenerCosto(M);



            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Lista();
        }

        private void dataFacturas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = dataFacturas.SelectedRows.Count > 0 ? dataFacturas.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                r.ID = Convert.ToInt32(dataFacturas["id", row].Value);
                r.Vehiculos = Convert.ToInt32(dataFacturas["vehiculo", row].Value);
                r.FechaInicio = Convert.ToDateTime( dataFacturas["fecha_inicio", row].Value.ToString());
                r.FechaFinal = Convert.ToDateTime( dataFacturas["fecha_final", row].Value.ToString());
                r.Cliente = Convert.ToInt32(dataFacturas["cliente", row].Value.ToString());
                r.Activo = Convert.ToBoolean(dataFacturas["activo", row].Value.ToString());
                r.Costo= Convert.ToInt32(dataFacturas["costo", row].Value);
               
               
            }
        }

        private void Reservaciones_Load(object sender, EventArgs e)
        {
            //CargarVehiculos();
            Lista();

        }
    }
}
