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
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form frm = new MAIN();
            frm.Show();
            this.Hide();
        }

        private void Loggin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
