using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega
{
    internal class ManejadorUsuario
    {
        public static string conectar = @"Data Source=EMANUEL\SISTEMAGESTION;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static Usuario ObtenerUsuario(long id)
        {
            Usuario usu = new Usuario();
            using (SqlConnection como = new SqlConnection(conectar))
            {
                SqlCommand comando = new SqlCommand($"select * from Usuario where id= @id ", como);

                comando.Parameters.AddWithValue("@id", id);
                como.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    usu.id = reader.GetInt64(0);
                }
            }
            return usu;
        }// fin del me


        public static Usuario ObtenerUsuarioLogin(string usuario, string contraseña)
        {
            Usuario usuarioLogin = new Usuario();

            using (SqlConnection conn = new SqlConnection(conectar))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario WHERE @NombreUsuario = NombreUsuario and @Contraseña = Contraseña", conn);
                comando.Parameters.AddWithValue("@NombreUsuario", usuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);

                conn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    Usuario usuario1 = new Usuario();
                    usuario1.id = reader.GetInt64(0);
                    usuario1.nombre = reader.GetString(1);
                    usuario1.apellido = reader.GetString(2);
                    usuario1.nombreusuario = reader.GetString(3);
                    usuario1.contraseña = reader.GetString(4);
                    usuario1.mail = reader.GetString(5);

                    usuarioLogin = usuario1;
                }
            }

            return usuarioLogin;
        }// fin de clase obtener usuario loguin


    }// fin clase manejador


}


