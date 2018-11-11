using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Simulador_de_negocios.Models;

namespace Simulador_de_negocios.Controllers
{
    public class Estimacion_serviciosController : Controller
    {
        private readonly Simulador_de_negociosContext _context;

        public Estimacion_serviciosController(Simulador_de_negociosContext context)
        {
            _context = context;
        }

        // GET: Estimacion_servicios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estimacion_servicios.ToListAsync());
        }

        // GET: Estimacion_servicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimacion_servicios = await _context.Estimacion_servicios
                .FirstOrDefaultAsync(m => m.id_suscripcion == id);
            if (estimacion_servicios == null)
            {
                return NotFound();
            }

            return View(estimacion_servicios);
        }

        // GET: Estimacion_servicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estimacion_servicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_suscripcion,unidad_produccion,total_suscripciones,total_mensual,producto_servicios_id_producto")] Estimacion_servicios estimacion_servicios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estimacion_servicios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estimacion_servicios);
        }

        // GET: Estimacion_servicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimacion_servicios = await _context.Estimacion_servicios.FindAsync(id);
            if (estimacion_servicios == null)
            {
                return NotFound();
            }
            return View(estimacion_servicios);
        }

        // POST: Estimacion_servicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_suscripcion,unidad_produccion,total_suscripciones,total_mensual,producto_servicios_id_producto")] Estimacion_servicios estimacion_servicios)
        {
            if (id != estimacion_servicios.id_suscripcion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estimacion_servicios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Estimacion_serviciosExists(estimacion_servicios.id_suscripcion))
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
            return View(estimacion_servicios);
        }

        // GET: Estimacion_servicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimacion_servicios = await _context.Estimacion_servicios
                .FirstOrDefaultAsync(m => m.id_suscripcion == id);
            if (estimacion_servicios == null)
            {
                return NotFound();
            }

            return View(estimacion_servicios);
        }

        // POST: Estimacion_servicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estimacion_servicios = await _context.Estimacion_servicios.FindAsync(id);
            _context.Estimacion_servicios.Remove(estimacion_servicios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Estimacion_serviciosExists(int id)
        {
            return _context.Estimacion_servicios.Any(e => e.id_suscripcion == id);
        }
    }
}
