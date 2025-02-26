using crud_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud_ASP.Controllers
{
    public class EmpleadoController : Controller
    {

        private readonly CrudExampleContext _context;

        public EmpleadoController(CrudExampleContext contex)
        {
            _context = contex;
        }

        public async Task<IActionResult> Index()
        {
            
            return View( await _context.TableEmpleados.ToListAsync() );
        }
    }
}
