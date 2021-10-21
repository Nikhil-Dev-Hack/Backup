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
    public class CommitsDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommitsDatasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CommitsDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommitsData.ToListAsync());
        }

        // GET: CommitsDatas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commitsData = await _context.CommitsData
                .FirstOrDefaultAsync(m => m.Email == id);
            if (commitsData == null)
            {
                return NotFound();
            }

            return View(commitsData);
        }

        // GET: CommitsDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommitsDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RepoId,CommitId,CommitDate,Email,Adds,Deletes,Edits,UserId,Comments,RemoteUrl,Url")] CommitsData commitsData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commitsData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(commitsData);
        }

        // GET: CommitsDatas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commitsData = await _context.CommitsData.FindAsync(id);
            if (commitsData == null)
            {
                return NotFound();
            }
            return View(commitsData);
        }

        // POST: CommitsDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("RepoId,CommitId,CommitDate,Email,Adds,Deletes,Edits,UserId,Comments,RemoteUrl,Url")] CommitsData commitsData)
        {
            if (id != commitsData.Email)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commitsData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommitsDataExists(commitsData.Email))
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
            return View(commitsData);
        }

        // GET: CommitsDatas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commitsData = await _context.CommitsData
                .FirstOrDefaultAsync(m => m.Email == id);
            if (commitsData == null)
            {
                return NotFound();
            }

            return View(commitsData);
        }

        // POST: CommitsDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var commitsData = await _context.CommitsData.FindAsync(id);
            _context.CommitsData.Remove(commitsData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommitsDataExists(string id)
        {
            return _context.CommitsData.Any(e => e.Email == id);
        }
    }
}
