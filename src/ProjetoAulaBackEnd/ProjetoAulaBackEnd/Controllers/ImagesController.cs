using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System;
using ProjetoAulaBackEnd.Models;

namespace ProjetoAulaBackEnd.Controllers
{
    public class ImagesController : Controller
    {

        [HttpGet]
        public IActionResult Index([FromServices] Contexto db)
        {
            return View(db.Image.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Image Image, IFormFile Img, [FromServices] Contexto db)
        {
            Image.Picture = Img.ToByteArray();
            Image.Length = (int)Img.Length;
            Image.Extension = Img.GetExtension();
            Image.ContentType = Img.ContentType;
            db.Image.Add(Image);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ResponseCache(Duration = 3600)]
        public FileResult Render(string id, [FromServices] Contexto db)
        {
            Guid _id = Guid.Parse(id);

            var item = db.Image
                .Where(x => x.Id == _id)
                .Select(s => new { s.Picture, s.ContentType })
                .FirstOrDefault();

            if (item != null)
            {
                return File(item.Picture, item.ContentType);
            }

            return null;
        }

    }
}