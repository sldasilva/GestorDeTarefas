using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeusAfazeres.Data;
using MeusAfazeres.Models;
using Microsoft.AspNetCore.Authorization;

namespace MeusAfazeres.Controllers
{
    [Authorize]
    public class FazerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FazerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Fazer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fazers
                .AsNoTracking()
                .Where(x=>x.Usuario == User.Identity.Name)
                .ToListAsync());
        }

        // GET: Fazer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fazer = await _context.Fazers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fazer == null)
            {
                return NotFound();
            }

            if (fazer.Usuario != User.Identity.Name)
            {
                return NotFound();
            }

            return View(fazer);
        }

        // GET: Fazer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fazer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Concluido,CriadoEm,DataUltimaAtualizacao,Usuario")] Fazer fazer)
        {
            if (ModelState.IsValid)
            {
                fazer.Usuario = User.Identity.Name;
                _context.Add(fazer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fazer);
        }

        // GET: Fazer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fazer = await _context.Fazers.FindAsync(id);
            if (fazer == null)
            {
                return NotFound();
            }

            if (fazer.Usuario != User.Identity.Name)
            {
                return NotFound();
            }

            return View(fazer);
        }

        // POST: Fazer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Concluido")] Fazer fazer)
        {
            if (id != fazer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    fazer.Usuario = User.Identity.Name;
                    fazer.DataUltimaAtualizacao = DateTime.Now;
                    _context.Update(fazer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FazerExists(fazer.Id))
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
            return View(fazer);
        }

        // GET: Fazer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fazer = await _context.Fazers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fazer == null)
            {
                return NotFound();
            }

            if (fazer.Usuario != User.Identity.Name)
            {
                return NotFound();
            }

            return View(fazer);
        }

        // POST: Fazer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fazer = await _context.Fazers.FindAsync(id);
            _context.Fazers.Remove(fazer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FazerExists(int id)
        {
            return _context.Fazers.Any(e => e.Id == id);
        }
    }
}
