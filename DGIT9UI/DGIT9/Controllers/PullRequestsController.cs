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
    public class PullRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PullRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PullRequests
        public async Task<IActionResult> Index()
        {
            return View(await _context.PullRequest1.ToListAsync());
        }

        // GET: PullRequests/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pullRequest = await _context.PullRequest1
                .FirstOrDefaultAsync(m => m.PullrequestId == id);
            if (pullRequest == null)
            {
                return NotFound();
            }

            return View(pullRequest);
        }

        // GET: PullRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PullRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PullrequestId,Title,Description,Reviewer,Url,SourceRefName,TargetRefName,LastMergeTargetCommit,LastMergeSourceCommit,LastMergeCommit,Status,RepoId,ProjectId,Workid,WorkUrl")] PullRequest pullRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pullRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pullRequest);
        }

        // GET: PullRequests/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pullRequest = await _context.PullRequest1.FindAsync(id);
            if (pullRequest == null)
            {
                return NotFound();
            }
            return View(pullRequest);
        }

        // POST: PullRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("PullrequestId,Title,Description,Reviewer,Url,SourceRefName,TargetRefName,LastMergeTargetCommit,LastMergeSourceCommit,LastMergeCommit,Status,RepoId,ProjectId,Workid,WorkUrl")] PullRequest pullRequest)
        {
            if (id != pullRequest.PullrequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pullRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PullRequestExists(pullRequest.PullrequestId))
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
            return View(pullRequest);
        }

        // GET: PullRequests/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pullRequest = await _context.PullRequest1
                .FirstOrDefaultAsync(m => m.PullrequestId == id);
            if (pullRequest == null)
            {
                return NotFound();
            }

            return View(pullRequest);
        }

        // POST: PullRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var pullRequest = await _context.PullRequest1.FindAsync(id);
            _context.PullRequest1.Remove(pullRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PullRequestExists(long id)
        {
            return _context.PullRequest1.Any(e => e.PullrequestId == id);
        }
    }
}
