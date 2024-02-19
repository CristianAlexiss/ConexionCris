using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConexionCris.Models
{
    [Table("veterinario")]
    public class Veterinario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string Name { get; set; }

        public int Edad {  get; set; }

        public int Telefono { get; set; }

    }
}
