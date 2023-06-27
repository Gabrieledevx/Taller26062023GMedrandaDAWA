using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller26062023GMedrandaDAWA.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Apellido { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Direccion { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]

        public string Telefono { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]

        public string Fecha_nac { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]

        public Boolean Estado { get; set; }
    }
}
