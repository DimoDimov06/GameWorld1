using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameWorld1.Data;
using GameWorld1.Models;

namespace GameWorld1.Controllers
{
    public class CatalogGamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CatalogGamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CatalogGames
        public async Task<IActionResult> Index()
        {
            return View(await _context.CatalogGame.ToListAsync());
        }

        // GET: CatalogGames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catalogGame = await _context.CatalogGame
                .FirstOrDefaultAsync(m => m.CatalogGameID == id);
            if (catalogGame == null)
            {
                return NotFound();
            }

            return View(catalogGame);
        }

        // GET: CatalogGames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatalogGames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatalogGameID,CatalogID,GameID,Comment")] CatalogGame catalogGame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catalogGame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catalogGame);
        }

        // GET: CatalogGames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catalogGame = await _context.CatalogGame.FindAsync(id);
            if (catalogGame == null)
            {
                return NotFound();
            }
            return View(catalogGame);
        }

        // POST: CatalogGames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatalogGameID,CatalogID,GameID,Comment")] CatalogGame catalogGame)
        {
            if (id != catalogGame.CatalogGameID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catalogGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatalogGameExists(catalogGame.CatalogGameID))
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
            return View(catalogGame);
        }

        // GET: CatalogGames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catalogGame = await _context.CatalogGame
                .FirstOrDefaultAsync(m => m.CatalogGameID == id);
            if (catalogGame == null)
            {
                return NotFound();
            }

            return View(catalogGame);
        }

        // POST: CatalogGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catalogGame = await _context.CatalogGame.FindAsync(id);
            if (catalogGame != null)
            {
                _context.CatalogGame.Remove(catalogGame);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatalogGameExists(int id)
        {
            return _context.CatalogGame.Any(e => e.CatalogGameID == id);
        }
    }
}
