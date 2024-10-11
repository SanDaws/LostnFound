using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LostnFound.Models
{
    [Table("categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//autogen db id
        [Column("id")]
        public uint Id { get; set; }
        [Column("name")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "cantidad de caracteres requeridos(min:5 ~ max: 255)")]
        public required string Name { get; set; }
        [Column("description")]
        public required string Description { get; set; }
    }
}