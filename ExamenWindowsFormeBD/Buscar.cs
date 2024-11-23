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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void btn_Buscar(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conexion = new SqlConnection(Constante.cadenaConexion))
                {
                    conexion.Open();

                    SqlCommand command = new SqlCommand("USP_BuscarProductoxID", conexion);
                    command.CommandType = CommandType.StoredProcedure;


                    SqlParameter sqlParameter = new SqlParameter("@idprod", SqlDbType.VarChar, 50);
                    sqlParameter.Value = txtIdProducto.Text;

                    command.Parameters.Add(sqlParameter);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    List<Productos> productos = new List<Productos>();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        productos.Add(new Productos
                        {
                            id = Convert.ToInt32(reader["IdProducto"]),
                            nombre = Convert.ToString(reader["Nombre"]),
                            precio = Convert.ToDecimal(reader["Precio"]),
                            stock = Convert.ToInt32(reader["Stock"]),
                            fecha = Convert.ToDateTime(reader["FechaCreacion"])
                        });

                    }

                    dgvProductos.DataSource = productos;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
