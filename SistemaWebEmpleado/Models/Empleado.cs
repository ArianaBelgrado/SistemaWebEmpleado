using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        public int EmpleadoId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Nombre")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Apellido")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el DNI")]
        public string DNI { get; set; }

        [RegularExpression(@"^[A-Z]{2}[1-9]{5}$", ErrorMessage = "Solo se aceptan dos letras y 5 numeros")]
        public string Legajo { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Titulo")]
        public string Titulo { get; set; }
        public DateTime? FechaNacimiento { get; set; }

    }
}
