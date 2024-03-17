using Microsoft.AspNetCore.Mvc;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;

namespace SistemaInventarioV7.Areas.Admin.Controllers
{
    public class BodegaController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        
        public IActionResult Index()
        {
            return View();
        }
    }
}
