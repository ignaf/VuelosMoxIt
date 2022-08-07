using System;
using System.Collections.Generic;
using System.Linq;
using Vuelos.Data;
using Vuelos.Data.Models;

namespace Vuelos.Repositorios
{
    public class VuelosRepositorio : IVuelosRepositorio
    {
        private EjercicioVuelosContext _ctx;

        public VuelosRepositorio(EjercicioVuelosContext ctx)
        {
            _ctx = ctx;
        }

        public void Agregar(Vuelo vuelo)
        {
            _ctx.Add(vuelo);
        }

        public Vuelo BuscarPorId(int id)
        {
            return _ctx.Vuelos.SingleOrDefault(m => m.Id == id);

        }

        public Vuelo BuscarPorNumeroDeVuelo(string numeroDeVuelo)
        {
            return _ctx.Vuelos.SingleOrDefault(m => m.NumeroDeVuelo == numeroDeVuelo);
        }

        public void Editar(Vuelo vuelo)
        {
            var vueloInDb = BuscarPorId(vuelo.Id);

            vueloInDb.LineaAerea = vuelo.LineaAerea;
            vueloInDb.Demorado = vuelo.Demorado;
            vueloInDb.FechaYHorarioDeLlegada = vuelo.FechaYHorarioDeLlegada;
            vueloInDb.NumeroDeVuelo = vuelo.NumeroDeVuelo;

        }

        public void Eliminar(int id)
        {
            _ctx.Vuelos.Remove(BuscarPorId(id));
        }

        public List<Vuelo> ListarTodos()
        {
            return _ctx.Vuelos.ToList();
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}
