using AutoMapper;
using System;
using System.Collections.Generic;
using Vuelos.Data.Models;
using Vuelos.Repositorios;
using Vuelos.ViewModels;

namespace Vuelos.Servicios
{
    public class VuelosServicio : IVuelosServicio
    {
        private IVuelosRepositorio _vuelosRepo;

        public VuelosServicio(IVuelosRepositorio vuelosRepo)
        {
            _vuelosRepo = vuelosRepo;
          
        }

        public void AgregarVuelo(VueloViewModel vueloVm)
        {
            var vuelo = new Vuelo
            {
                NumeroDeVuelo = vueloVm.NumeroDeVuelo,
                FechaYHorarioDeLlegada = vueloVm.FechaYHorarioDeLlegada,
                Demorado = vueloVm.Demorado,
                LineaAerea = vueloVm.LineaAerea

            };
            
            _vuelosRepo.Agregar(vuelo);
            _vuelosRepo.SaveChanges();
        }

        public void EditarVuelo(EditarVueloViewModel vueloVm)
        {
            var vuelo = new Vuelo
            {
                Id = vueloVm.Id,
                NumeroDeVuelo = vueloVm.NumeroDeVuelo,
                FechaYHorarioDeLlegada = vueloVm.FechaYHorarioDeLlegada,
                Demorado = vueloVm.Demorado,
                LineaAerea = vueloVm.LineaAerea

            };

           _vuelosRepo.Editar(vuelo);
            _vuelosRepo.SaveChanges();

        }

        public void EliminarVuelo(int id)
        {
            _vuelosRepo.Eliminar(id);
            _vuelosRepo.SaveChanges();
        }


        public List<Vuelo> ListarVuelos()
        {
            return _vuelosRepo.ListarTodos();
        }

        public EditarVueloViewModel ObtenerVueloPorId(int id)
        {
            var vuelo = _vuelosRepo.BuscarPorId(id);
            var vuelovm = new EditarVueloViewModel
            {
                Demorado = vuelo.Demorado,
                FechaYHorarioDeLlegada = vuelo.FechaYHorarioDeLlegada,
                LineaAerea = vuelo.LineaAerea,
                NumeroDeVuelo = vuelo.NumeroDeVuelo

            };
            return vuelovm;
        }
    }
}
