using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {

            Form frm = new MantenimientoUsuarios();
            frm.Show();
            this.Hide();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Form frm = new MantenimientoClientes();
            frm.Show();
            this.Hide();

        }

        private void BtnVeh_Click(object sender, EventArgs e)
        {

            Form frm = new MantenimientoVehiculos();
            frm.Show();
            this.Hide();
        }

        private void BtnSedes_Click(object sender, EventArgs e)
        {
            Form frm = new MantenimientoSedes();
            frm.Show();
            this.Hide();

        }

        private void MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {

            string mensaje = "¿Está seguro que desea salir del menú principal?";
            string caption = "Cerrar Menú";
            var resultado = MessageBox.Show(mensaje, caption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (Application.OpenForms["Loggin"] != null)
                {
                    Application.OpenForms["Loggin"].Show();
                }
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }
    }
}
