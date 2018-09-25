using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace GUI_V_2
{
    public partial class Principal : Form
    {

        bool logmaster, log;
        int dni = 0;
        conexion cn = new conexion();

        PruebasAdd prueb = new PruebasAdd();
        public Principal()
        {
            
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        public void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
          
        public void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        public void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        public void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            Console.WriteLine("Finalizo Abrir Form");
        }

        public void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuAvion());
            
        }

        public void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new InicioResumen());
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null,e);
        }

        public void button5_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuModelos());
        }

         void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuPruebas());
        }
        public void abrirpanel() { 
}

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuTecnico());
            SubMenu.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuControladorAereo());
            SubMenu.Visible = false;
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            SubMenu.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BtnConectar.Visible = false;
            BtnDesconectar.Visible = true;
        }
        public bool user_Exist(String user, String password)
        {
            SqlDataReader reader = cn.getQuery("Select username,password FROM USUARIOS;");
            String ussern="", pass="";
            while (reader.Read())
            {
                ussern =(String)reader.GetSqlString(0);
                pass = (String)reader.GetSqlString(1);
                MessageBox.Show(ussern + " " + pass);
               /* if(ussern.Equals(user) && pass.Equals(password))
                {
                    dni = reader.GetInt32(2);
                    return true;
                }*/
            }
            return false;
        }
        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            if (user_Exist(username.Text, password.Text))
            {
                lbluser.Text = username.Text;
                SqlDataReader reader = cn.getQuery("Select correo FROM TECNICOS_EU WHERE DNI="+dni+";");
                Console.WriteLine(reader.GetString(0));



            }
            cn.desconectar();

            BtnConectar.Visible = true;
            BtnDesconectar.Visible = false;
        }

    }
}
