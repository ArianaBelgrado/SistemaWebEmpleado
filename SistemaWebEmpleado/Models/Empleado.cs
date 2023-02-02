using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaWebEmpleado.Validation;

namespace SistemaWebEmpleado.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Nombre")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Apellido")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el DNI")]
        public string DNI { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Legajo")]
        [RegularExpression(@"^[A-Z]{2}[1-9]{5}$", ErrorMessage = "Solo se aceptan dos letras y 5 numeros")]
        public string Legajo { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Debe ingresar el Fecha")]
        [ValidDateTime]
        [DisplayFormat(ApplyFormatInEditMode = true,
            DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime? FechaNacimiento { get; set; }

    }
}
