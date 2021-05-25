using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PC03.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string LugarCompra { get; set; }
        public int Categoria { get; set; }

        public ICollection<Producto> Productos {get;set;}
    }
}