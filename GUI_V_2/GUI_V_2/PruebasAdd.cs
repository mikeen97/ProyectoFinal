using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class PruebasAdd : Form
    {
        conexion cn = new conexion();
        public PruebasAdd(){
            InitializeComponent();

        }
        private void Pruebas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //PnCrearTecnico2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //PnCrearTecnico2.Visible = false;
            //MessageBox.Show("Se creo exitosamente el Tecnico", "My Application",
            //MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = cn.getQuery("Select DNI from TECNICOS");
            while (combo_box_tecnico.Items.Count > 0)
            {
                combo_box_tecnico.Items.Remove(0);
            }
            while (reader.Read())
            {
                combo_box_tecnico.Items.Add((int)reader.GetInt32(0));

            }


            cn.desconectar();
        }

        private void label3_Click(object sender, EventArgs e)

        {
            string valor_combo_box = combo_box_tecnico.Text;
            Console.WriteLine(valor_combo_box);

            SqlDataReader reader = cn.getQuery("Select num_modelo from TECNICOSXMODELOS AS TXM JOIN TECNICOS AS T ON TXM.DNI = " + valor_combo_box+";");
            while (combo_box_registro.Items.Count > 0)
            {
                combo_box_registro.Items.Remove(0);
            }
            while (reader.Read())
            {
                combo_box_registro.Items.Add((int)reader.GetInt32(0));

            }


            cn.desconectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor_combo_box = combo_box_tecnico.Text;
            Console.WriteLine(valor_combo_box);

            SqlDataReader reader = cn.getQuery("Select correo from TECNICOS AS T WHERE T.DNI = " + valor_combo_box + ";");
            //while (combo_box_registro.Items.Count > 0)
            // {
            //   combo_box_registro.Items.Remove(0);
            //}
            var correo = "";
            while (reader.Read())
            {
                correo = reader.GetString(0);
                Console.WriteLine(correo.ToString());

            }

            //--------------ENVIAR CORREO------------------------
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            //message.To.Add(txtPara.Text);
            message.To.Add(correo);
            //message.Subject = txtAsunto.Text;
            message.Subject = "PRUEBA DE AEROPUERTO AGENDADA";
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            //message.Bcc.Add(txtBBC.Text);
            //message.Bcc.Add(txtBBC.Text);//obviado

            //message.Body = txtMensaje.Text;
            message.Body = "Por este medio se le comunica al Tecnico, que se ha agendado una prueba en el Aeropuerto";
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            message.From = new System.Net.Mail.MailAddress("TACAbrondatabase@hotmail.com");

            System.Net.Mail.SmtpClient Cliente = new System.Net.Mail.SmtpClient();

            Cliente.Credentials = new System.Net.NetworkCredential("TACAbrondatabase@hotmail.com", "Holamundo007");

            //puerto para gmail
            Cliente.Port = 587;
            Cliente.EnableSsl = true;

            Cliente.Host = "smtp.live.com";//mail.dominio.com

            try
            {
                Cliente.Send(message);
            }
            catch
            {
                MessageBox.Show("Error al enviar");
            }

            MessageBox.Show("Se ha agendado la cita exitosamente!, Hemos enviado un correo al Tecnico correspondiente");

            cn.desconectar();
        }
    }
}
