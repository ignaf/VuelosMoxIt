using System;
using System.Collections.Generic;
using Vuelos.Data.Models;

namespace Vuelos.Repositorios
{
    public interface IVuelosRepositorio
    {
        public void Agregar(Vuelo vuelo);
        public List<Vuelo> ListarTodos();

        public void Editar(Vuelo vuelo);

        public void Eliminar(int id);
        public Vuelo BuscarPorId(int id);

        public Vuelo BuscarPorNumeroDeVuelo(string numeroDeVuelo);

        public void SaveChanges();
    }
}
