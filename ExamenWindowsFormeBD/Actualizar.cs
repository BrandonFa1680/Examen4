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

namespace ExamenWindowsFormeBD
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void btn_Actualizar(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterID = null;
            SqlParameter sqlParameterNombre = null;
            SqlParameter sqlParameterPrecio = null;
            SqlParameter sqlParameterStock = null;


            Productos producto = new Productos
            {
                id = Convert.ToInt32(txtId.Text),
                nombre = txtNombre.Text,
                precio = Convert.ToInt32(txtPrecio.Text),
                stock = Convert.ToInt32(txtStock.Text)
            };

            try
            {
                using (SqlConnection connection = new SqlConnection(Constante.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_ActualizarProductos", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterID = new SqlParameter("@IdProducto", SqlDbType.Int);
                    sqlParameterID.Value = producto.id;

                    sqlParameterNombre = new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
                    sqlParameterNombre.Value = producto.nombre;

                    sqlParameterPrecio = new SqlParameter("@Precio", SqlDbType.Decimal);
                    sqlParameterPrecio.Value = producto.precio;

                    sqlParameterStock = new SqlParameter("@Stock", SqlDbType.Int);
                    sqlParameterStock.Value = producto.stock;

                    sqlCommand.Parameters.Add(sqlParameterID);
                    sqlCommand.Parameters.Add(sqlParameterNombre);
                    sqlCommand.Parameters.Add(sqlParameterPrecio);
                    sqlCommand.Parameters.Add(sqlParameterStock);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Actualización satisfatoria");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error comuniquese con el administrador");
            }
        }

        private void btn_Buscar(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            SqlParameter sqlParameterID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(Constante.cadenaConexion))
                {
                    connection.Open();

                    sqlCommand = new SqlCommand("USP_BuscarProductoxID", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlParameterID = new SqlParameter("@idprod", SqlDbType.Int);
                    sqlParameterID.Value = Convert.ToInt32(txtId.Text);

                    sqlCommand.Parameters.Add(sqlParameterID);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        txtId.Text = Convert.ToString(reader["IdProducto"]);
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtPrecio.Text = Convert.ToString(reader["precio"]);
                        txtStock.Text = Convert.ToString(reader["stock"]);
                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error comuniquese con el administrador");
            }
        }
    }
}
