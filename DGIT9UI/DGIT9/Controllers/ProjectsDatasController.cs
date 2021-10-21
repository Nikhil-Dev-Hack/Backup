using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DGIT9.Data;
using DGIT9.Models;
using Microsoft.AspNetCore.Authorization;

namespace DGIT9.Controllers
{
    [Authorize]
    public class ProjectsDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectsDatasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectsDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectsData1.ToListAsync());
        }

        // GET: ProjectsDatas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectsData = await _context.ProjectsData1
                .FirstOrDefaultAsync(m => m.ProjectName == id);
            if (projectsData == null)
            {
                return NotFound();
            }

            return View(projectsData);
        }

        // GET: ProjectsDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectsDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectName,ProjectId,Description,URL,ReposCount")] ProjectsData projectsData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectsData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectsData);
        }

        // GET: ProjectsDatas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectsData = await _context.ProjectsData1.FindAsync(id);
            if (projectsData == null)
            {
                return NotFound();
            }
            return View(projectsData);
        }

        // POST: ProjectsDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProjectName,ProjectId,Description,URL,ReposCount")] ProjectsData projectsData)
        {
            if (id != projectsData.ProjectName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectsData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectsDataExists(projectsData.ProjectName))
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
            return View(projectsData);
        }

        // GET: ProjectsDatas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectsData = await _context.ProjectsData1
                .FirstOrDefaultAsync(m => m.ProjectName == id);
            if (projectsData == null)
            {
                return NotFound();
            }

            return View(projectsData);
        }

        // POST: ProjectsDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var projectsData = await _context.ProjectsData1.FindAsync(id);
            _context.ProjectsData1.Remove(projectsData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectsDataExists(string id)
        {
            return _context.ProjectsData1.Any(e => e.ProjectName == id);
        }
    }
}
