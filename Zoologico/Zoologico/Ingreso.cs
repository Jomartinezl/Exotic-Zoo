using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoologico
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnVerPassword_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == (char)0)
            {
                txtContraseña.PasswordChar = '*';
            }
            else
            {
                txtContraseña.PasswordChar = (char)0;
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Felipe23" && txtContraseña.Text == "1234" || txtUsuario.Text == "Jonatan19" && txtContraseña.Text == "5678" || txtUsuario.Text == "Maleja04" && txtContraseña.Text == "ferxxo" || txtUsuario.Text == "JuanD" && txtContraseña.Text == "1011")
            {
                MessageBox.Show("Sesion iniciada");

                var frm = new Menu();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
