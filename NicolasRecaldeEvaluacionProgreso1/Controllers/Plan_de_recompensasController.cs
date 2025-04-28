using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NicolasRecaldeEvaluacionProgreso1.Models;

namespace NicolasRecaldeEvaluacionProgreso1.Controllers
{
    public class Plan_de_recompensasController : Controller
    {
        private readonly NicolasRecaldeEvaluacionProgreso1ContextSQLServer _context;

        public Plan_de_recompensasController(NicolasRecaldeEvaluacionProgreso1ContextSQLServer context)
        {
            _context = context;
        }

        // GET: Plan_de_recompensas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Plan_de_recompensas.ToListAsync());
        }

        // GET: Plan_de_recompensas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan_de_recompensas = await _context.Plan_de_recompensas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plan_de_recompensas == null)
            {
                return NotFound();
            }

            return View(plan_de_recompensas);
        }

        // GET: Plan_de_recompensas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plan_de_recompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,FechaInicio,PuntosAcumulados")] Plan_de_recompensas plan_de_recompensas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plan_de_recompensas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plan_de_recompensas);
        }

        // GET: Plan_de_recompensas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan_de_recompensas = await _context.Plan_de_recompensas.FindAsync(id);
            if (plan_de_recompensas == null)
            {
                return NotFound();
            }
            return View(plan_de_recompensas);
        }

        // POST: Plan_de_recompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,FechaInicio,PuntosAcumulados")] Plan_de_recompensas plan_de_recompensas)
        {
            if (id != plan_de_recompensas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plan_de_recompensas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Plan_de_recompensasExists(plan_de_recompensas.Id))
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
            return View(plan_de_recompensas);
        }

        // GET: Plan_de_recompensas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan_de_recompensas = await _context.Plan_de_recompensas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plan_de_recompensas == null)
            {
                return NotFound();
            }

            return View(plan_de_recompensas);
        }

        // POST: Plan_de_recompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plan_de_recompensas = await _context.Plan_de_recompensas.FindAsync(id);
            if (plan_de_recompensas != null)
            {
                _context.Plan_de_recompensas.Remove(plan_de_recompensas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Plan_de_recompensasExists(int id)
        {
            return _context.Plan_de_recompensas.Any(e => e.Id == id);
        }
    }
}
