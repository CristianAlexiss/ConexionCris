using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConexionCris.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NumCita { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCita { get; set; }

        public string Foto { get; set; }
    }
}
