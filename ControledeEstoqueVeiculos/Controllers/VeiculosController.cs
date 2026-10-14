using ControledeEstoqueVeiculos.Data;
using ControledeEstoqueVeiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControledeEstoqueVeiculos.Controllers;

public class VeiculosController : Controller
{
    private readonly AppDbContext _context;

    public VeiculosController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var veiculos = await _context.Veiculos.ToListAsync();
        return View(veiculos);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if(id is null) return NotFound();
        var veiculo = await _context.Veiculos.FirstOrDefaultAsync(m => m.Id == id);
        if (veiculo is null) return NotFound();

        return View(veiculo);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Marca,Modelo,Ano,Cor,Preco,Tipo,Situacao")] Veiculo veiculo)
    {
        if (ModelState.IsValid)
        {
            _context.Add(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(veiculo);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id is null) return NotFound();

        var veiculo = await _context.Veiculos.FindAsync(id);
        if (veiculo is null) return NotFound();

        return View(veiculo);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Modelo,Ano,Cor,Preco,Tipo,Situacao,IsAtivo")] Veiculo veiculo)
    {
        if (id != veiculo.Id) return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(veiculo);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculoExists(veiculo.Id)) return NotFound();
                else throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(veiculo);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id is null) return NotFound();

        var veiculo = await _context.Veiculos.FirstOrDefaultAsync(m => m.Id == id);
        if (veiculo is null) return NotFound();

        return View(veiculo);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var veiculo = await _context.Veiculos.FindAsync(id);
        if (veiculo is not null)
        {
            veiculo.IsAtivo = false;
            _context.Update(veiculo);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    private bool VeiculoExists(int id)
    {
        return _context.Veiculos.Any(e => e.Id == id);
    }
}