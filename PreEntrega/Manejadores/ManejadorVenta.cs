using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega
{
    public static class ManejadorVenta
    {
        public static string conectar = @"Data Source=EMANUEL\SISTEMAGESTION;Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Venta> ObtenerVentas(long idUsuario)
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection conn = new SqlConnection(conectar))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Venta WHERE @IdUsuario = idUsuario", conn);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Venta ventaTemp = new Venta();
                        ventaTemp.id = reader.GetInt64(0);
                        ventaTemp.comentario = reader.GetString(1);
                        ventaTemp.idusuario = reader.GetInt64(2);
                        ventas.Add(ventaTemp);
                    }
                }

                return ventas;

            }

        }


    }
}


