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
            cargarVehiculos();
        }

        private void Facturar_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            //txtSubTotal = Costo;
            //double iva = txtCosto * 0.13;
            //txtIVA = iva;
            //txtTotal = costo+iva;
        }

        private void cargarVehiculos()
        {
            cmbUsers.DataSource = rdal.ObtenerUser();
            cmbUsers.DisplayMember = "Nombre";
            cmbUsers.ValueMember = "ID";
            cmbMarca.DataSource = rdal.ObtenerVehiculo();
            cmbMarca.DisplayMember = "Marca";
            cmbMarca.ValueMember = "ID";
            string id = cmbMarca.SelectedText;
            cmbModelo.DataSource = rdal.ObtenerModelo(id);
            cmbModelo.DisplayMember = "Modelo";
            cmbModelo.ValueMember = "ID";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

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

        }
    }
}
