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
    public partial class ControladorAereoAdd : Form
    {
        conexion cn = new conexion();

        public ControladorAereoAdd()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ControladorAereo_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            cn.ExecuteQuery("EXECUTE INSERT_CONTROLADOR " + txt_dni.Text + "," + txt_afiliacion.Text + "," + "\"" + txt_nombre.Text + "\""
                            + "," + "\""+fecha_cs.Value.ToString("yyyy-MM-dd") +"\""+ "," + "\"" + txt_username.Text + "\"" + "," + "\"" + txt_contrasena.Text + "\"" + ";");
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ExecuteQuery("EXECUTE UPDATE_CONTROLADOR " + txt_dni.Text + "," + txt_afiliacion.Text + "," + "\"" + txt_nombre.Text + "\""
                            + "," + "\"" + fecha_cs.Value.ToString("yyyy-MM-dd") + "\"" + "," + "\"" + txt_username.Text + "\"" + "," + "\"" + txt_contrasena.Text + "\"" + ";");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = cn.getQuery("Select * From CONTROLADOR_EU WHERE DNI="+ txt_dni.Text+";");
            while (reader.Read())
            {
                txt_dni.Text =reader.GetInt32(0)+"";
                txt_nombre.Text = (String) reader.GetString(1);
                txt_afiliacion.Text = reader.GetInt32(2)+"";
                txt_username.Text = (String)reader.GetString(4);
                txt_contrasena.Text = reader.GetString(5);

       
            }
            cn.desconectar();
        }
    }
}
