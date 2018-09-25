using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class MenuControladorAereo : Form
    {
        public MenuControladorAereo()
        {
            InitializeComponent();
        }
        public void AbrirFormMenu2(object Formhijo)
        {
            if (this.ContenedorMenuAvion.Controls.Count > 0)
                this.ContenedorMenuAvion.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.ContenedorMenuAvion.Controls.Add(fh);
            this.ContenedorMenuAvion.Tag = fh;
            fh.Show();
            Console.WriteLine("Finalizo Abrir Form");
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormMenu2(new ControladorAereoAdd());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormMenu2(new ControladorAereoDelete());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormMenu2(new ControladorAereoFind());
        }
    }
}
