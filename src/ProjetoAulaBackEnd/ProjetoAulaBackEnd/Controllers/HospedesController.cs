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
    public class HospedesController : Controller
    {
        private readonly Contexto _context;

        public HospedesController(Contexto context)
        {
            _context = context;
        }

        // GET: Hospedes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hospedes.ToListAsync());
        }

        // GET: Hospedes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospede = await _context.Hospedes
                .FirstOrDefaultAsync(m => m.IdHospede == id);
            if (hospede == null)
            {
                return NotFound();
            }

            return View(hospede);
        }

        // GET: Hospedes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hospedes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHospede,Nome,CPF,DataDeNascimento,Endereco,Telefone,Email,Senha,Senha2")] Hospede hospede)
        {
           
            if (hospede.Senha != hospede.Senha2)
            {
              ViewBag.Message= "Senhas não conferem. Digite novamente";
                return View();
            }
 
                if (ModelState.IsValid)
                {
                    hospede.Senha=BCrypt.Net.BCrypt.HashPassword(hospede.Senha);
                    hospede.Senha2 = BCrypt.Net.BCrypt.HashPassword(hospede.Senha2);
                    _context.Add(hospede);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(hospede);
            
        }

        // GET: Hospedes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospede = await _context.Hospedes.FindAsync(id);
            if (hospede == null)
            {
                return NotFound();
            }

           
            return View(hospede);
        }

        // POST: Hospedes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHospede,Nome,CPF,DataDeNascimento,Endereco,Telefone,Email,Senha,Senha2")] Hospede hospede)
        {
            if (id != hospede.IdHospede)
            {
                return NotFound();
            }
            if (hospede.Senha != hospede.Senha2)
            {
                ViewBag.Message = "Senhas não conferem. Digite novamente";
                return View();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    hospede.Senha = BCrypt.Net.BCrypt.HashPassword(hospede.Senha);
                    hospede.Senha2 = BCrypt.Net.BCrypt.HashPassword(hospede.Senha2);
                    _context.Update(hospede);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HospedeExists(hospede.IdHospede))
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
            return View(hospede);
        }

        // GET: Hospedes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospede = await _context.Hospedes
                .FirstOrDefaultAsync(m => m.IdHospede == id);
            if (hospede == null)
            {
                return NotFound();
            }

            return View(hospede);
        }

        // POST: Hospedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hospede = await _context.Hospedes.FindAsync(id);
            _context.Hospedes.Remove(hospede);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HospedeExists(int id)
        {
            return _context.Hospedes.Any(e => e.IdHospede == id);
        }
    }
}
