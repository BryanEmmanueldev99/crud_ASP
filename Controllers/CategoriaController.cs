using crud_ASP.Models;
using crud_ASP.Models.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud_ASP.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly CrudExampleContext _context;

        public CategoriaController(CrudExampleContext contex)
        {
            _context = contex;
        }
        public async Task<IActionResult> Index()
        {
            // En caso de recuperar información de la tabla relacionada var categorias = _context.Categorias.Include(p =>  p.Productos);
            var categorias = _context.Categorias;
            return View( await categorias.ToListAsync() );
        }

        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Store(CategoriaViewModel modelAtribute)
        {
           
            if(ModelState.IsValid)
            {
                var categoria = new Categoria()
                {
                    NombreCategoria = modelAtribute.NombreCategoria
                };

                //agregamos contexto
                _context.Add(categoria);

                //guardamos en la base de datos
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
     
            }

           return View(modelAtribute);
        }
    }
}
