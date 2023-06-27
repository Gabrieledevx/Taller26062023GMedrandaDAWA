using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller26062023GMedrandaDAWA.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateOnly FechaNac { get; set; }
        public Boolean estado { get; set; }
        public Cliente(int id, string nombre, string apellido, string direccion, string telefono, DateOnly fechaNac, bool estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            FechaNac = fechaNac;
            this.estado = estado;
        }
    }
}
