using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaWebEmpleado.Validation
{
    public class ValidDateTime : ValidationAttribute
    {
        public ValidDateTime()
        {
            ErrorMessage = "El año debe ser Mayor o igual a 2000";
        }
        public override bool IsValid(object value)
        {
            DateTime fecha = (DateTime)value;
            int year = fecha.Year;

            if (year < 2000)
            {
                return false;

            }
            else
            {
                return true;
            }

        }
    }
}