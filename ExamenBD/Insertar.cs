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
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void btn_Insertar(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterNombre = null;
            SqlParameter sqlParameterPrecio = null;
            SqlParameter sqlParameterStock = null;


            Productos producto = new Productos
            {
                nombre = txtNombre.Text,
                precio = Convert.ToInt32(txtPrecio.Text),
                stock = Convert.ToInt32(txtStock.Text)
            };

            try
            {
                using (SqlConnection connection = new SqlConnection(Constante.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_InsertarProducto", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterNombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                    sqlParameterNombre.Value = producto.nombre;

                    sqlParameterPrecio = new SqlParameter("@Precio", SqlDbType.Decimal);
                    sqlParameterPrecio.Value = producto.precio;

                    sqlParameterStock = new SqlParameter("@Stock", SqlDbType.Int);
                    sqlParameterStock.Value = producto.stock;

                    sqlCommand.Parameters.Add(sqlParameterNombre);
                    sqlCommand.Parameters.Add(sqlParameterPrecio);
                    sqlCommand.Parameters.Add(sqlParameterStock);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Registro del producto satisfatoriamente");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
