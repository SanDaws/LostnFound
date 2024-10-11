using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LostnFound.Dto.Request
{
    public class DtoCategoryRegister
    {
        [StringLength(255, MinimumLength = 5, ErrorMessage = "cantidad de caracteres requeridos(min:5 ~ max: 255)")]
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}