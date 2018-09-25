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
    public partial class ModeloAdd : Form
    {
        conexion cn = new conexion();
        public ModeloAdd()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ExecuteQuery("EXECUTE INSERT_MODELO " + text_num.Text + "," + spin_capacidad.Value + "," + spin_peso.Value+";");

        }

        private void Modelos_Load(object sender, EventArgs e)
        {

        }

        private void spinner2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.ExecuteQuery("EXECUTE UPDATE_MODELO " + text_num.Text + "," + spin_capacidad.Value + "," +  spin_peso.Value+ ";");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = cn.getQuery("Select * From MODELOS WHERE num_modelo=" + text_num.Text + ";");
            while (reader.Read())
            {
                text_num.Text = reader.GetInt32(0) + "";
                spin_capacidad.Value= reader.GetInt32(1);
                spin_peso.Value= reader.GetDecimal(2);

            }
            cn.desconectar();
        }
    }
}
