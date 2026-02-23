using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SimpleNotesApp.Controllers
{
    public class HomeController : Controller
    {
        private static List<string> notes = new List<string>();

        public IActionResult Index()
        {
            int x = "error";
            return View(notes);
        }

        [HttpPost]
        public IActionResult Add(string note)
        {
            if (!string.IsNullOrEmpty(note))
                notes.Add(note);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (id >= 0 && id < notes.Count)
                notes.RemoveAt(id);

            return RedirectToAction("Index");
        }
    }
}