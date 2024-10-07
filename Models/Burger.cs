using System.ComponentModel.DataAnnotations;

namespace KamilaRevelo_EjercicioCF.Models
{
    public class Burger
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.02, 9999.98)]
        public decimal Precio { get; set; }
    }
}
