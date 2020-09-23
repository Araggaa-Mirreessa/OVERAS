using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OVERAS.Models;

namespace OVERAS.Controllers
{
    public class CustomertsRigistrationController : Controller
    {
        private readonly CustomerDB _context;

        public CustomertsRigistrationController(CustomerDB context)
        {
            _context = context;
        }

        // GET: CustomertsRigistration
        public async Task<IActionResult> Index()
        {
            return View(await _context.customertb12.ToListAsync());
        }

        // GET: CustomertsRigistration/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customert = await _context.customertb12
                .FirstOrDefaultAsync(m => m.cid == id);
            if (customert == null)
            {
                return NotFound();
            }

            return View(customert);
        }

        // GET: CustomertsRigistration/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomertsRigistration/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cid,fname,mname,lname,currentaddress,ffname,mmname,llname")] customert customert)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customert);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customert);
        }

        // GET: CustomertsRigistration/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customert = await _context.customertb12.FindAsync(id);
            if (customert == null)
            {
                return NotFound();
            }
            return View(customert);
        }

        // POST: CustomertsRigistration/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cid,fname,mname,lname,currentaddress,ffname,mmname,llname")] customert customert)
        {
            if (id != customert.cid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customert);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!customertExists(customert.cid))
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
            return View(customert);
        }

        // GET: CustomertsRigistration/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customert = await _context.customertb12
                .FirstOrDefaultAsync(m => m.cid == id);
            if (customert == null)
            {
                return NotFound();
            }

            return View(customert);
        }

        // POST: CustomertsRigistration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customert = await _context.customertb12.FindAsync(id);
            _context.customertb12.Remove(customert);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool customertExists(int id)
        {
            return _context.customertb12.Any(e => e.cid == id);
        }
    }
}
