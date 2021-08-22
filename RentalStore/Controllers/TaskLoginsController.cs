using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentalStore.Data;
using RentalStore.Models;

namespace RentalStore.Controllers
{
    public class TaskLoginsController : Controller
    {
        private readonly RentalStoreContext _context;

        public TaskLoginsController(RentalStoreContext context)
        {
            _context = context;
        }

        // GET: TaskLogins
        public async Task<IActionResult> Index()
        {
            return View(await _context.TaskLogin.ToListAsync());
        }

        // GET: TaskLogins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskLogin = await _context.TaskLogin
                .FirstOrDefaultAsync(m => m.id == id);
            if (taskLogin == null)
            {
                return NotFound();
            }

            return View(taskLogin);
        }

        // GET: TaskLogins/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult BookStore()
        {
            return View();
        }
        public IActionResult Wrong()
        {
            return View();
        }


        // POST: TaskLogins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Email,Password")] TaskLogin taskLogin)
        {
            if (taskLogin.Email.Equals("BookStore@gmail.com") && taskLogin.Password.Equals("12345"))
            {

                return RedirectToAction(nameof(BookStore));
            }
            else {
                return RedirectToAction(nameof(Wrong));
            }

            
        }

        // GET: TaskLogins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskLogin = await _context.TaskLogin.FindAsync(id);
            if (taskLogin == null)
            {
                return NotFound();
            }
            return View(taskLogin);
        }

        // POST: TaskLogins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Email,Password")] TaskLogin taskLogin)
        {
            if (id != taskLogin.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskLogin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskLoginExists(taskLogin.id))
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
            return View(taskLogin);
        }

        // GET: TaskLogins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskLogin = await _context.TaskLogin
                .FirstOrDefaultAsync(m => m.id == id);
            if (taskLogin == null)
            {
                return NotFound();
            }

            return View(taskLogin);
        }

        // POST: TaskLogins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskLogin = await _context.TaskLogin.FindAsync(id);
            _context.TaskLogin.Remove(taskLogin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskLoginExists(int id)
        {
            return _context.TaskLogin.Any(e => e.id == id);
        }
    }
}
