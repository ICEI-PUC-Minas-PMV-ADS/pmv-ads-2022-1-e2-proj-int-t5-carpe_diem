using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email, Senha")] Hospede hospede)
        {
           
            var user = await _context.Hospedes
                .FirstOrDefaultAsync(m => m.Email == hospede.Email);

            if (user == null)
            {
                ViewBag.Message = "Email e/ou Senha inválidos!";
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(hospede.Senha, user.Senha);
            
            if (isSenhaOk)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user.Nome),
                    new Claim(ClaimTypes.Role, user.TipoUsuario.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);    

                return Redirect("/");

            }

            ViewBag.Message = "Email e/ou Senha inválidos!";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Hospedes");
        }


        public IActionResult AcessoNegado()
        {
            return View();
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int id, [Bind("TipoUsuario")] Hospede hospede)
        {
            if (id != hospede.IdHospede)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
              
                try
                {
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
        public async Task<IActionResult> Create([Bind("IdHospede,Nome,CPF,DataDeNascimento,Endereco,Telefone,Email,Senha,Senha2,TipoUsuario")] Hospede hospede)
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
                    hospede.TipoUsuario = 0;
                    _context.Add(hospede);
                    await _context.SaveChangesAsync();
                    ViewBag.Message = "Cadastro realizado com sucesso!";
                    //return RedirectToAction(nameof(Create));
                    
            }

           
            return View();
            
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
                ViewBag.Message = "Atualização realizada com sucesso!";
                //return RedirectToAction(nameof(Index));
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
