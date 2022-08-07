using System;
using System.ComponentModel.DataAnnotations;
using Vuelos.ViewModels.Validaciones;

namespace Vuelos.ViewModels
{
    public class VueloViewModel
    {

        [Required(ErrorMessage ="Campo obligatorio.")]
        [Display(Name ="Número de Vuelo")]
        [ValidarNumeroExiste(ErrorMessage ="El número de vuelo ya existe")]
        public string NumeroDeVuelo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [ValidarFecha(ErrorMessage="La fecha debe ser posterior al día de hoy.")]
        [Display(Name ="Fecha y Horario de Llegada")]
        [DataType(DataType.Date, ErrorMessage ="Campo obligatorio.")]
        public DateTime FechaYHorarioDeLlegada { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Display(Name ="Línea Aerea")]
        public string LineaAerea { get; set; }

        public bool Demorado { get; set; }
    }
}
