using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NicolasRecaldeEvaluacionProgreso1.Controllers
{
    public class PlanDeRecompensas : Controller
    {
        // GET: PlanDeRecompensas
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlanDeRecompensas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanDeRecompensas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanDeRecompensas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanDeRecompensas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlanDeRecompensas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanDeRecompensas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlanDeRecompensas/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
