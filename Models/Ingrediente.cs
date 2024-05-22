using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventarios_Restaurante.Models
{
    public class Ingrediente
    {
        //[Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Column(TypeName ="decimal(6,2)")]
        public double CantidadDisponible { get; set; }
        public string UnidadMedida { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
