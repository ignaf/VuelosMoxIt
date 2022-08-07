using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Data;
using Vuelos.Repositorios;

namespace Vuelos.ViewModels.Validaciones
{
    public class ValidarNumeroExisteAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            EjercicioVuelosContext _ctx = (EjercicioVuelosContext)validationContext.GetService(typeof(EjercicioVuelosContext));

            var vuelo = _ctx.Vuelos.SingleOrDefault(m => m.NumeroDeVuelo == value.ToString());

            if (vuelo==null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage);
            }
        }
    }
}
