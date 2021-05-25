using System.Collections.Generic;

namespace PC03.Models
{
    public class Producto
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public ICollection<Cliente> Clientes{ get; set; }
    }
}