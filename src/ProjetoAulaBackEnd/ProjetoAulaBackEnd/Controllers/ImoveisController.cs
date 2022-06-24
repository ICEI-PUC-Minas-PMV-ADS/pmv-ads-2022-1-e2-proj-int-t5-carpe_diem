using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoAulaBackEnd.Models;

namespace ProjetoAulaBackEnd.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly Contexto _context;

        public ImoveisController(Contexto context)
        {
            _context = context;
        }

        // GET: Imoveis
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Imoveis.Include(i => i.Hospede);
            return View(await contexto.ToListAsync());
        }

        // GET: Imoveis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Imoveis == null)
            {
                return NotFound();
            }

            var imovel = await _context.Imoveis
                .Include(i => i.Hospede)
                .FirstOrDefaultAsync(m => m.IdImovel == id);
            if (imovel == null)
            {
                return NotFound();
            }

            return View(imovel);
        }

        // GET: Imoveis/Create
        public IActionResult Create()
        {
            ViewData["HospedeId"] = new SelectList(_context.Hospedes, "IdHospede", "CPF");
            return View();
        }

        // POST: Imoveis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdImovel,HospedeId,Endereco,Bairro,Cidade,TipoEsp,TipoAc,QtdeHospedes,QtdeCamas,QtdeQuartos,QtdeBanheiros,Foto1,Foto2,Foto3,Foto4,Academia,PET,ArCondicionado,Churrasqueira,Cozinha,DuchaExterna,Elevador,Estacionamento,Jogos,Lareira,MaquinaLavar,Patio,Piscina,Rampa,Sauna,Suite,VistaMar,WiFi,CheckIn,CheckOut,DistanciaPraia,ValorDiaria,DispImovel,DesativarImovel")] Imovel imovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HospedeId"] = new SelectList(_context.Hospedes, "IdHospede", "CPF", imovel.HospedeId);
            return View(imovel);
        }

        // GET: Imoveis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Imoveis == null)
            {
                return NotFound();
            }

            var imovel = await _context.Imoveis.FindAsync(id);
            if (imovel == null)
            {
                return NotFound();
            }
            ViewData["HospedeId"] = new SelectList(_context.Hospedes, "IdHospede", "CPF", imovel.HospedeId);
            return View(imovel);
        }

        // POST: Imoveis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdImovel,HospedeId,Endereco,Bairro,Cidade,TipoEsp,TipoAc,QtdeHospedes,QtdeCamas,QtdeQuartos,QtdeBanheiros,Foto1,Foto2,Foto3,Foto4,Academia,PET,ArCondicionado,Churrasqueira,Cozinha,DuchaExterna,Elevador,Estacionamento,Jogos,Lareira,MaquinaLavar,Patio,Piscina,Rampa,Sauna,Suite,VistaMar,WiFi,CheckIn,CheckOut,DistanciaPraia,ValorDiaria,DispImovel,DesativarImovel")] Imovel imovel)
        {
            if (id != imovel.IdImovel)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImovelExists(imovel.IdImovel))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["HospedeId"] = new SelectList(_context.Hospedes, "IdHospede", "CPF", imovel.HospedeId);
            return View(imovel);
        }

        // GET: Imoveis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Imoveis == null)
            {
                return NotFound();
            }

            var imovel = await _context.Imoveis
                .Include(i => i.Hospede)
                .FirstOrDefaultAsync(m => m.IdImovel == id);
            if (imovel == null)
            {
                return NotFound();
            }

            return View(imovel);
        }

        // POST: Imoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Imoveis == null)
            {
                return Problem("Entity set 'Contexto.Imoveis'  is null.");
            }
            var imovel = await _context.Imoveis.FindAsync(id);
            if (imovel != null)
            {
                _context.Imoveis.Remove(imovel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImovelExists(int id)
        {
          return _context.Imoveis.Any(e => e.IdImovel == id);
        }
        //Busca Imóveis
        public async Task<IActionResult> Busca(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            var imoveisResult = from s in _context.Imoveis
                                select s;



            if (!String.IsNullOrEmpty(searchString))
            {
                imoveisResult = imoveisResult.Where(s => s.Cidade.Contains(searchString)
                                       || s.Bairro.Contains(searchString));
            }

            if (String.IsNullOrEmpty(searchString))
            {
                return RedirectToAction(nameof(BuscaVazia));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    imoveisResult = imoveisResult.OrderByDescending(s => s.Cidade);
                    break;
                case "Date":
                    imoveisResult = imoveisResult.OrderBy(s => s.ValorDiaria);
                    break;
                case "date_desc":
                    imoveisResult = imoveisResult.OrderByDescending(s => s.Bairro);
                    break;
                default:
                    imoveisResult = imoveisResult.OrderBy(s => s.Cidade);
                    break;
            }
            return View(await imoveisResult.AsNoTracking().ToListAsync());
        }
        public IActionResult BuscaVazia()
        {
            return View();
        }
    }
}
