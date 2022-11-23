using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XSS_Exemple.Models
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public string Texto { get; set; }
    }
}
