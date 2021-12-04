using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIMUSICA.Models
{
    public class Canciones
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nombre_cancion { get; set; }
        [Required]
        public String Artista { get; set; }
        [Required]
        public String Album { get; set; }
        [Required]
        public string URLCancion { get; set; }
        [Required]
        public String URLImagen { get; set; }
        [Required]
        public String Genero { get; set; }
    }
}
