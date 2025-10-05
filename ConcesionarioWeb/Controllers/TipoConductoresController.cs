using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConcesionarioWeb.Data;
using ConcesionarioWeb.Models;

namespace ConcesionarioWeb.Controllers;

public class TipoConductoresController : Controller
{
    private readonly ConcesionarioContext _context;
    public TipoConductoresController(ConcesionarioContext context) => _context = context;

    public async Task<IActionResult> Index(string? q)
    {
        var query = _context.TipoConductores.AsQueryable();
        if (!string.IsNullOrWhiteSpace(q))
            query = query.Where(t => t.Nombre.Contains(q));
        var list = await query.OrderBy(t => t.Nombre).ToListAsync();
        ViewData["q"] = q;
        return View(list);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();
        var TipoConductor = await _context.TipoConductores.FirstOrDefaultAsync(m => m.Id == id);
        if (TipoConductor == null) return NotFound();
        return View(TipoConductor);
    }

    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Nombre")] TipoConductor TipoConductor)
    {
        if (ModelState.IsValid)
        {
            _context.Add(TipoConductor);
            await _context.SaveChangesAsync();
            TempData["msg"] = "Tipo de conductor creado exitosamente.";
            return RedirectToAction(nameof(Index));
        }
        TempData["msg"] = "Error al crear el tipo de conductor.";
        return View(TipoConductor);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();
        var TipoConductor = await _context.TipoConductores.FindAsync(id);
        if (TipoConductor == null) return NotFound();
        return View(TipoConductor);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoConductor TipoConductor)
    {
        if (id != TipoConductor.Id) return NotFound();
        if (!ModelState.IsValid) return View(TipoConductor);

        try
        {
            _context.Update(TipoConductor);
            await _context.SaveChangesAsync();
            TempData["msg"] = "Tipo de conductor actualizado exitosamente.";
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.TipoConductores.Any(e => e.Id == id)) return NotFound();
            else
            TempData["msg"] = "Error al actualizar el tipo de conductor.";
            throw;
        }
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();
        var TipoConductor = await _context.TipoConductores.FirstOrDefaultAsync(m => m.Id == id);
        if (TipoConductor == null) return NotFound();
        return View(TipoConductor);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var TipoConductor = await _context.TipoConductores.FindAsync(id);
        if (TipoConductor != null)
        {
            _context.TipoConductores.Remove(TipoConductor);
            await _context.SaveChangesAsync();
            TempData["msg"] = "Tipo de conductor eliminado exitosamente.";
        }
        else
        {
            TempData["msg"] = "Error al eliminar el tipo de conductor.";
        }
        return RedirectToAction(nameof(Index));
    }
}
