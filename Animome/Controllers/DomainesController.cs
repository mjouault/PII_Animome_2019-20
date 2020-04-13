﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Animome.Data;
using Animome.Models;

namespace Animome.Controllers
{
    public class DomainesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DomainesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Domaines
        public async Task<IActionResult> Index()
        {
            return View(await _context.Domaine.ToListAsync());
        }

        // GET: Domaines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domaine = await _context.Domaine
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domaine == null)
            {
                return NotFound();
            }

            return View(domaine);
        }

        // GET: Domaines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Domaines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Intitule")] Domaine domaine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(domaine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(domaine);
        }

        // GET: Domaines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domaine = await _context.Domaine.FindAsync(id);
            if (domaine == null)
            {
                return NotFound();
            }
            return View(domaine);
        }

        // POST: Domaines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Intitule")] Domaine domaine)
        {
            if (id != domaine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(domaine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DomaineExists(domaine.Id))
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
            return View(domaine);
        }

        // GET: Domaines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domaine = await _context.Domaine
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domaine == null)
            {
                return NotFound();
            }

            return View(domaine);
        }

        // POST: Domaines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var domaine = await _context.Domaine.FindAsync(id);
            var suivi = await _context.Suivi.FindAsync(id);

            var suiviExercicesSupprimes = await _context.SuiviExercice.Where(e => e.SuiviNiveau.SuiviPrerequis.SuiviCompetence.Suivi.Domaine.Id == id).ToListAsync();
            if (suiviExercicesSupprimes != null)
            {
                foreach (var i in suiviExercicesSupprimes)
                {
                    _context.Remove(i);
                }
            }

            var suiviNiveauxSupprimes = await _context.SuiviNiveau.Where(e => e.SuiviPrerequis.SuiviCompetence.Suivi.Domaine.Id == id).ToListAsync();
            if (suiviNiveauxSupprimes != null)
            {
                foreach (var i in suiviNiveauxSupprimes)
                {
                    _context.Remove(i);
                }
            }

            var suiviPrerequisSupprimes = await _context.SuiviPrerequis.Where(e => e.SuiviCompetence.Suivi.Domaine.Id == id).ToListAsync();
            if (suiviPrerequisSupprimes != null)
            {
                foreach (var i in suiviPrerequisSupprimes)
                {
                    _context.Remove(i);
                }
            }

            var suiviCompetenceSupprimes = await _context.SuiviCompetence.Where(e => e.Suivi.Domaine.Id == id).ToListAsync();
            if (suiviCompetenceSupprimes != null)
            {
                foreach (var i in suiviCompetenceSupprimes)
                {
                    _context.Remove(i);
                }
            }

            var suiviApplicationUserSupprimes = await _context.SuiviApplicationUser.Where(e => e.Suivi.Id == id).ToListAsync();
            if (suiviApplicationUserSupprimes != null)
            {
                foreach (var i in suiviApplicationUserSupprimes)
                {
                    _context.Remove(i);
                }
            }

            var domaineUserSupprimes = await _context.DomaineUser.Where(e => e.Domaine.Id == id).ToListAsync();
            if (domaineUserSupprimes != null)
            {
                foreach (var i in domaineUserSupprimes)
                {
                    _context.Remove(i);
                }
            }

            var suiviSupprimes = await _context.Suivi.Where(e => e.Domaine.Id == id).ToListAsync();
            if (suiviSupprimes != null)
            {
                foreach (var i in suiviSupprimes)
                {
                    _context.Remove(i);
                }
            }

            var domaineCompetenceSupprimes = await _context.DomaineCompetence.Where(e => e.Domaine.Id == id).ToListAsync();
            if (domaineCompetenceSupprimes != null)
            {
                foreach (var i in domaineCompetenceSupprimes)
                {
                    _context.Remove(i);
                }
            }
            _context.Domaine.Remove(domaine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DomaineExists(int id)
        {
            return _context.Domaine.Any(e => e.Id == id);
        }
    }
}
