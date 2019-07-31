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

namespace GUI
{
    public partial class Loggin : Form
    {
        Usuario usu;
        UsuarioBOL ubol;
        public Loggin()
        {
            InitializeComponent();
            usu = new Usuario();
            ubol = new UsuarioBOL();
        }

        private void Llenar()
        {
            usu.User = txtUsu.Text;
            usu.Password = txtContraseña.Text;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Llenar();
            ubol.Iniciar(usu);
            txtUsu.ResetText();
            txtContraseña.ResetText();
            
            Form frm = new MAIN();
            frm.Show();
            this.Hide();
        }

        private void Loggin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
