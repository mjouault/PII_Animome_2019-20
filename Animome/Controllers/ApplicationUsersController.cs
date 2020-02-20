﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Animome.Data;
using Animome.Models;
using Microsoft.EntityFrameworkCore;
using Animome.ViewModels;

namespace Animome.Controllers
{
    public class ApplicationUsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationUser> _roleManager;

        public ApplicationUsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationUser> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _userManager.Users
                .Include(user => user.LesDomaineUsers)
                .ThenInclude(lesDomainesUsers => lesDomainesUsers.Domaine).ToListAsync());
        }


        public IActionResult AfficherProfil()
        {

            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
            return View(user);
            //.Include(lesDomainesUsers => lesDomainesUsers.Domaine).ToListAsync());

            /*return View(await _userManager.Users
                .Include(user => user.LesDomaineUsers)
                .ThenInclude(lesDomainesUsers => lesDomainesUsers.Domaine).ToListAsync());*/
        }

        // POST: Domaines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreerDomaine(DomaineCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.GetUserAsync(User);

                Domaine domaineToAdd = new Domaine
                {
                    LesDomaines = viewModel.Domaine.LesDomaines,
                    Intitule = viewModel.Domaine.Intitule
                };

                DomaineUser domaineUserToAdd = new DomaineUser
                {
                    Domaine = domaineToAdd,
                    User = user
                };

                _context.Add(domaineToAdd);
                _context.Add(domaineUserToAdd);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

    }
}
