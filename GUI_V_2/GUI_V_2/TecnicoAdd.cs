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

    public partial class TecnicoAdd : Form
    {
        public conexion cn = new conexion();
        public TecnicoAdd()
        {
            InitializeComponent();
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //INSERTAR UN TECNICO EN LA TABLA TECNICO
            cn.ExecuteQuery("EXECUTE INSERT_TECNICO \"" + txt_dni.Text + "\",\"" + txt_afiliacion.Text + "\",\"" + txt_nombre.Text + "\",\"" + txt_direccion.Text + "\",\"" +
                                                        txt_telefono.Text + "\"," + txt_sueldo.Text + ",\"" + txt_username.Text + "\",\"" + txt_contra.Text + "\",\"" + txt_correo.Text + "\";");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BUSCAR TECNICO Y LLENAR LOS LABELS 
            SqlDataReader reader = cn.getQuery("Select * From TECNICOS_EU WHERE DNI=" + txt_dni.Text + ";");
            while (reader.Read())
            {
                txt_dni.Text = reader.GetInt32(0) + "";
                txt_nombre.Text = (String)reader.GetString(1);
                txt_afiliacion.Text = reader.GetInt32(2) +"";
                txt_direccion.Text = reader.GetString(3);
                txt_telefono.Text = reader.GetInt32(5) + "";
                txt_sueldo.Text = reader.GetDecimal(4) + "";
                txt_username.Text = reader.GetString(6);
                txt_contra.Text = reader.GetString(7);
                txt_correo.Text = reader.GetString(8);
            }
            cn.desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BUSCAR Y MODIFICAR UN TECNICO
            cn.ExecuteQuery("EXECUTE UPDATE_TECNICO " +"\""+ txt_dni.Text +"\"" +"," + txt_afiliacion.Text + "," +"\""+ txt_nombre.Text +"\"" +","
                +"\""+ txt_direccion.Text + "\"" + "," + txt_telefono.Text  + ","  + txt_sueldo.Text  + "," +
                 "\"" + txt_username.Text + "\"" + "," + txt_contra.Text +","+ "\""+ txt_correo.Text +"\""+";");
        }
    }
}
