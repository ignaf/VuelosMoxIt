using System;
using System.Collections.Generic;
using Vuelos.Data.Models;
using Vuelos.ViewModels;

namespace Vuelos.Servicios
{
    public interface IVuelosServicio
    {
        public List<Vuelo> ListarVuelos();
        public EditarVueloViewModel ObtenerVueloPorId(int id);
        public void AgregarVuelo(VueloViewModel vueloVm);
        public void EditarVuelo(EditarVueloViewModel vueloVm);
        public void EliminarVuelo(int id);

    }
}
