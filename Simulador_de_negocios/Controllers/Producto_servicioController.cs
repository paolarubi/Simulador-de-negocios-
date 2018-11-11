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
    public class Producto_servicioController : Controller
    {
        private readonly Simulador_de_negociosContext _context;

        public Producto_servicioController(Simulador_de_negociosContext context)
        {
            _context = context;
        }

        // GET: Producto_servicio
        public async Task<IActionResult> Index()
        {
            return View(await _context.Producto_servicio.ToListAsync());
        }

        // GET: Producto_servicio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto_servicio = await _context.Producto_servicio
                .FirstOrDefaultAsync(m => m.id_producto == id);
            if (producto_servicio == null)
            {
                return NotFound();
            }

            return View(producto_servicio);
        }

        // GET: Producto_servicio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producto_servicio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_producto,nombre_producto,unidad_produccion,produccion_mensual,costo_unitario,margen_utilidad,precio_publico,datos_empresa_id_empresa")] Producto_servicio producto_servicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto_servicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto_servicio);
        }

        // GET: Producto_servicio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto_servicio = await _context.Producto_servicio.FindAsync(id);
            if (producto_servicio == null)
            {
                return NotFound();
            }
            return View(producto_servicio);
        }

        // POST: Producto_servicio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_producto,nombre_producto,unidad_produccion,produccion_mensual,costo_unitario,margen_utilidad,precio_publico,datos_empresa_id_empresa")] Producto_servicio producto_servicio)
        {
            if (id != producto_servicio.id_producto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto_servicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Producto_servicioExists(producto_servicio.id_producto))
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
            return View(producto_servicio);
        }

        // GET: Producto_servicio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto_servicio = await _context.Producto_servicio
                .FirstOrDefaultAsync(m => m.id_producto == id);
            if (producto_servicio == null)
            {
                return NotFound();
            }

            return View(producto_servicio);
        }

        // POST: Producto_servicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto_servicio = await _context.Producto_servicio.FindAsync(id);
            _context.Producto_servicio.Remove(producto_servicio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Producto_servicioExists(int id)
        {
            return _context.Producto_servicio.Any(e => e.id_producto == id);
        }
    }
}
