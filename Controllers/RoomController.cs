using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class RoomController : Controller
    {
        // User Story 2B: Implement content filtering for room index view (Max Lasitsa)
        // GET: RoomController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoomController/Details/5
        public ActionResult Details(int id)
        {
            // Changes Sprint 1 -- "As a message posting user, I want to create rooms for categorizing conversations." -- Bethany Helwig
            return View();
            // Changes Sprint 1 -- I want to create room details for identifying rooms -- Alec Lindberg  
        }

        // User Story 2B: Ensure content filtering when creating a room (Max Lasitsa)
        // GET: RoomController/Create
        public ActionResult Create()
        {
            // Changes Sprint 1 -- "As a message posting user, I want to create rooms for categorizing conversations." -- Bethany Helwig
            return View();
            // Changes Sprint 1 -- I want to create rooms for catergorizing convertations -- Alec Lindberg 
        }

        // User Story 2D: Implement logic to enforce room user limits during creation (Max Lasitsa)
        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // User Story 2D: Ensure user limits are enforced when editing room details (Max Lasitsa)
        // GET: RoomController/Edit/5
        public ActionResult Edit(int id)
        {
            // Changes Sprint 1 -- "As a message posting user, I want to create rooms for categorizing conversations." -- Bethany Helwig
            return View();
            //  Changes Sprint 1 -- I want to create an edit option for editing room informtaion -- Alec Lindberg
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        {
            // Changes Sprint 1 -- "As a message posting user, I want to create rooms for categorizing conversations." -- Bethany Helwig
            return View();
            // Changes Sprint 1 -- I want to create a delete option for deleting rooms --Alec Lindberg
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
