using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XSSExemple_Cliente.Models
{
    public class Tokens
    {
        [Key]
        public int Id { get; set; }
        public string Token { get; set; }
    }
}
