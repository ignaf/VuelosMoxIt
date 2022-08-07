using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Vuelos.Data.Models;
using Vuelos.Servicios;
using Vuelos.ViewModels;
using Vuelos.Web.Models;

namespace Vuelos.Web.Controllers
{
    public class VuelosController : Controller
    {
        private IVuelosServicio _vuelosService;
        public VuelosController(IVuelosServicio vuelosService)
        {
            _vuelosService = vuelosService;
        }



        public IActionResult Listar()
        {
            List<Vuelo> vuelos = _vuelosService.ListarVuelos();
            return View(vuelos);
        }

        [Route("Vuelos/Form")]
        public IActionResult GuardarVuelo()
        {
            return View("FormularioAgregarVuelo");
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult GuardarVuelo(VueloViewModel vueloVm)
        {
            if (!ModelState.IsValid)
            {
                return View("FormularioAgregarVuelo");
            }

            _vuelosService.AgregarVuelo(vueloVm);
            return RedirectToAction(nameof(Listar));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult EditarVuelo(EditarVueloViewModel vueloVm)
        {
            if (!ModelState.IsValid)
            {
                return View("EditarFormularioVuelo");
            }

            _vuelosService.EditarVuelo(vueloVm);
            return RedirectToAction(nameof(Listar));
        }


        [Route("Vuelos/Editar")]
        public IActionResult ElegirVueloAEditar()
        {
            List<Vuelo> vuelos = _vuelosService.ListarVuelos();
            return View("EditarVuelo", vuelos);
        }

        [Route("Vuelos/Editar/{id}")]
        public IActionResult EditarVuelo(int id)
        { 
            var vuelovm = _vuelosService.ObtenerVueloPorId(id);
            
            return View("FormularioEditarVuelo", vuelovm);
        }


        public IActionResult Eliminar()
        {
            List<Vuelo> vuelos = _vuelosService.ListarVuelos();
            return View(vuelos);
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            _vuelosService.EliminarVuelo(id);
            return RedirectToAction(nameof(Listar));
        }


    }
}
