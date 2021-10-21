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
    public class ReposDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReposDatasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReposDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReposData1.ToListAsync());
        }

        // GET: ReposDatas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reposData = await _context.ReposData1
                .FirstOrDefaultAsync(m => m.ProjectName == id);
            if (reposData == null)
            {
                return NotFound();
            }

            return View(reposData);
        }

        // GET: ReposDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReposDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RepoName,RepoId,RepoURL,DefaultBranch,ProjectName,CommitCount")] ReposData reposData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reposData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reposData);
        }

        // GET: ReposDatas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reposData = await _context.ReposData1.FindAsync(id);
            if (reposData == null)
            {
                return NotFound();
            }
            return View(reposData);
        }

        // POST: ReposDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("RepoName,RepoId,RepoURL,DefaultBranch,ProjectName,CommitCount")] ReposData reposData)
        {
            if (id != reposData.ProjectName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reposData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReposDataExists(reposData.ProjectName))
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
            return View(reposData);
        }

        // GET: ReposDatas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reposData = await _context.ReposData1
                .FirstOrDefaultAsync(m => m.ProjectName == id);
            if (reposData == null)
            {
                return NotFound();
            }

            return View(reposData);
        }

        // POST: ReposDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var reposData = await _context.ReposData1.FindAsync(id);
            _context.ReposData1.Remove(reposData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReposDataExists(string id)
        {
            return _context.ReposData1.Any(e => e.ProjectName == id);
        }
    }
}
