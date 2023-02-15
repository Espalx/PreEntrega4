using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega
{
    internal class Producto
    {
        private long Id { get; set; }
        private string Descripciones { get; set; }
        private decimal Costo { get; set; }
        private decimal PrecioVenta { get; set; }
        private int Stock { get; set; }
        private long IdUsuario { get; set; }
        // metodos de acceso
        public long id
        {
            get => Id; set => Id = value;
        }
        public string descripciones
        {
            get => Descripciones; set => Descripciones = value;
        }
        public decimal costo
        {
            get => Costo; set => Costo = value;
        }
        public decimal precioventa
        {
            get => PrecioVenta; set => PrecioVenta = value;
        }
        public int stock
        {
            get => Stock; set => Stock = value;
        }
        public long idusuario
        {
            get => IdUsuario; set => IdUsuario = value;
        }
        public Producto()
        {

        }
        public Producto(long id, string descripciones, decimal costo, decimal precioventa, int stock, long idusuario)
        {
            this.Id = id;
            this.Descripciones = descripciones;
            this.Costo = costo;
            this.PrecioVenta = precioventa;
            this.Stock = stock;
            this.IdUsuario = idusuario;
        }
    }
}

