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

namespace GUI
{
    public partial class MenúReserva : Form
    {
        ReservacionBOL rbol;
        public MenúReserva()
        {
            InitializeComponent();
        }

        private void rentarCreta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Reservaciones();
            frm.Show();
            this.Hide();
        }

       
    }
}
