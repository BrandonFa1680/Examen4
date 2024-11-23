using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenBD
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btn_Eliminar(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(Constante.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_EliminarProductoxID", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterID = new SqlParameter("@idprod", SqlDbType.Int);
                    sqlParameterID.Value = txtIdProducto.Text;

                    sqlCommand.Parameters.Add(sqlParameterID);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Elimación satisfatoria");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
