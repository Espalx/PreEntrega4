using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PreEntrega
{
    internal class ManejadorProducto
    {
        public static string conectar = @"Data Source=EMANUEL\SISTEMAGESTION;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<Producto> obtenerProducto()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection con = new SqlConnection(conectar))
            {
                SqlCommand cmd = new SqlCommand("select * from Producto ", con);

                con.Open();
                SqlDataReader red = cmd.ExecuteReader();
                if (red.HasRows)
                {
                    while (red.Read())
                    {
                        Producto produTemporal = new Producto();
                        produTemporal.id = red.GetInt64(0);
                        produTemporal.descripciones = red.GetString(1);
                        produTemporal.costo = red.GetDecimal(2);
                        produTemporal.precioventa = red.GetDecimal(3);
                        produTemporal.stock = red.GetInt32(4);
                        produTemporal.idusuario = red.GetInt64(5);

                        productos.Add(produTemporal);

                    }
                }
                return productos;

            }
        }

        public static Producto ObtenerProducto(string descripciones)
        {
            Producto producto = new Producto();
            using (SqlConnection como = new SqlConnection(conectar))
            {
                SqlCommand comando = new SqlCommand($"SELECT * FROM Producto WHERE Descripciones='{descripciones}' ", como);

                comando.Parameters.AddWithValue("@descripciones", descripciones);
                como.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    producto.id = reader.GetInt64(0);
                    producto.descripciones = reader.GetString(1);
                    producto.costo = reader.GetDecimal(2);
                    producto.precioventa = reader.GetDecimal(3);
                    producto.stock = reader.GetInt32(4);
                    producto.idusuario = reader.GetInt64(5);
                }
            }
            return producto;
        }// fin del metodo buscar

        public static int insertarproducto(Producto producto)
        {
            using (SqlConnection cone = new SqlConnection(conectar))
            {

                SqlCommand comando = new SqlCommand("insert into Producto (Descripciones,Costo,PrecioVenta,Stock,IdUsuario) values (@descripciones,@costo,@precioventa,@stock,@idusuario) ", cone);

                comando.Parameters.AddWithValue("@descripciones", producto.descripciones);
                comando.Parameters.AddWithValue("@costo", producto.costo);
                comando.Parameters.AddWithValue("@precioventa", producto.precioventa);
                comando.Parameters.AddWithValue("@stock", producto.stock);
                comando.Parameters.AddWithValue("@idusuario", producto.idusuario);
                cone.Open();

                return comando.ExecuteNonQuery();
            }
        }// fin insertar producto

        // ejercicio 3, obtener la ventas por el id
        public static Producto ObtenerProducto(long id)
        {
            Producto producto = new Producto();
            using (SqlConnection como = new SqlConnection(conectar))
            {
                SqlCommand comando = new SqlCommand($"SELECT * FROM Producto WHERE id= ", como);

                SqlCommand comando2 = new SqlCommand("select * from Producto where Id=@id", como);

                comando.Parameters.AddWithValue("@id", id);
                como.Open();
                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    producto.id = reader.GetInt64(0);
                    producto.descripciones = reader.GetString(1);
                    producto.costo = reader.GetDecimal(2);
                    producto.precioventa = reader.GetDecimal(3);
                    producto.stock = reader.GetInt32(4);
                    producto.idusuario = reader.GetInt64(5);
                }
            }
            return producto;
        }// fin del metodo buscar

        public static List<Producto> ObtenerProductosVendidos(long idUsuario)
        {
            List<long> ListaidProductos = new List<long>();
            //Producto producto = new Producto();

            using (SqlConnection como = new SqlConnection(conectar))
            {
                SqlCommand comando2 = new SqlCommand(" select IdProducto  from Venta\r\ninner join ProductoVendido\r\non Venta.Id=ProductoVendido.IdVenta\r\nwhere IdUsuario=IdUsuario", como);

                comando2.Parameters.AddWithValue("@idusuario", idUsuario);
                como.Open();
                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        ListaidProductos.Add(reader.GetInt64(0));
                    }
                }

            }
            // agrego una lista--- y guardo los productos
            List<Producto> productos = new List<Producto>();
            foreach (var id in ListaidProductos)
            {
                Producto productoTemporal = ObtenerProducto(id);
                productos.Add(productoTemporal);

            }
            return productos;


        }//  fin obtener productos vendidos...





    }// fin manejador producto


}/// fin de la clase pre entrega