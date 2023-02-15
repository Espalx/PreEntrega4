using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega
{
    internal class Usuario
    {
        private long Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string NombreUsuario { get; set; }
        private string Contraseña { get; set; }
        private string Mail { get; set; }
       
        public long id
        {
            get => Id; set => Id = value;
        }
        public string nombre
        {
            get => Nombre; set => Nombre = value;
        }
        public string apellido
        {
            get => Apellido; set => Apellido = value;
        }
        public string nombreusuario
        {
            get => NombreUsuario; set => NombreUsuario = value;
        }
        public string contraseña
        {
            get => Contraseña; set => Contraseña = value;
        }
        public string mail
        {
            get => Mail; set => Mail = value;
        }

        public Usuario()
        {

        }
        public Usuario(long id, string nombre, string apellido, string nombreusuario, string contraseña, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreusuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }


        
        public override string ToString()
        {
            return $"Id:{Id} Nombre: {Nombre} \"Apellido: {Apellido} \"NombreUsuario: {NombreUsuario} \"Contraseña: {Contraseña}   \"Mail: {Mail}";
        }
    }
}

