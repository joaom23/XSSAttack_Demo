using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XSS_Exemple.Models
{
    public class Tokens
    {
        [Key]
        public int Id { get; set; }
        public string Token { get; set; }
    }
}
