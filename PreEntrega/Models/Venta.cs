using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega
{
    internal class Venta
    {

        private long Id { get; set; }
        private string Comentario { get; set; }
        private long IdUsuario { get; set; }

        public long id
        {
            get => Id; set => Id = value;
        }
        public string comentario
        {
            get => Comentario; set => Comentario = value;
        }
        public long idusuario
        {
            get => IdUsuario; set => IdUsuario = value;
        }
        public Venta()
        {

        }
        public Venta(long id, string comentario, long idusuario)
        {
            this.Id = id;
            this.Comentario = comentario;
            this.IdUsuario = idusuario;
        }
    }
}
