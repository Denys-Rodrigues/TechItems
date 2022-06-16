using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechItems.Context;
using TechItems.Models;

namespace TechItems.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly AppCont _appCont;

        public ProdutosController(AppCont appCont)
        {
            _appCont = appCont;
        }

        public IActionResult Index()
        {
            var allTask = _appCont.Produtos.ToList();
            return View(allTask);
        }

        // GET: Produtos/Details
        public async Task<IActionResult> Details(long? id) // O "?" é para ele aceitar os valores nulos, para não dar B.O no código
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _appCont.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Produtos/Delete
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _appCont.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var produto = await _appCont.Produtos.FindAsync(id);
            _appCont.Produtos.Remove(produto);
            await _appCont.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
