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

namespace PuntoDeVenta
{
    public partial class RegistroProveedor : Form
    {
        public RegistroProveedor()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try{
                SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=puntoVentaTony;Trusted_Connection=True;");
                con.Open();

                SqlDataAdapter adap = new SqlDataAdapter("AddEditProv", con);

                adap.SelectCommand.CommandType = CommandType.StoredProcedure;

                adap.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar,(15)).Value = textBox1.Text;
                adap.SelectCommand.Parameters.Add("@apellidos", SqlDbType.NChar, (15)).Value = textBox2.Text;
                adap.SelectCommand.Parameters.Add("@empresa", SqlDbType.NChar, (15)).Value = textBox3.Text;
                adap.SelectCommand.Parameters.Add("@fechaEntrega", SqlDbType.Date).Value = textBox4.Text;
                /*adap.SelectCommand.Parameters.Add("@sexo", SqlDbType.Char).Value = rbMasc.Text;
                adap.SelectCommand.Parameters.Add("@sexo", SqlDbType.Char).Value = rbFem.Text;*/
                adap.SelectCommand.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Bien hecho paps.");
            }
            catch(Exception exp){
                MessageBox.Show("No se pudo conectar con el servior :( "+exp);
            }

        }
    }
}
