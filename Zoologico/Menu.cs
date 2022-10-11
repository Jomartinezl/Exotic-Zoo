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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistroAnimal_Click(object sender, EventArgs e)
        {
            var frm = new Información_del_animal();
            frm.Show();
            this.Hide();
        }

        private void btnRegistroEnfermería_Click(object sender, EventArgs e)
        {
            var frm = new Registro_enfermeríacs();
            frm.Show();
            this.Hide();
        }
    }
}
