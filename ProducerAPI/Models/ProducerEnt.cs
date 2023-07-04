using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProducerAPI.Models
{
    public class ProducerEnt
    {
        [Key]
        [Required]
       public int Id { get; set; }
        public string Name{ get; set; }     = string.Empty;
    }
}
