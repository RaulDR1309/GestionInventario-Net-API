using System.ComponentModel.DataAnnotations; // Para usar validaciones

namespace GestionInventario.Api.Models
{
    public class Producto
    {
        [Key] // Indica que este será el ID único en la base de datos
        public int Id { get; set; }

        [Required] // Indica que el nombre no puede estar vacío
        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; } // El "?" significa que puede ser nulo

        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}
