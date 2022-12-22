using Microsoft.AspNetCore.Mvc;
using ToDoApp.Data;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class TaskkController : Controller
    {
        private readonly ApplicationDbContext _db;


        public TaskkController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Taskk> objTaskList = _db.Taskks;
            return View(objTaskList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Taskk obj)
        {
            if (ModelState.IsValid)
            {
                _db.Taskks.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var taskkFromDb = _db.Taskks.Find(id);

            if(taskkFromDb == null)
            {
                return NotFound();
            }
            return View(taskkFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Taskk obj)
        {
            if (ModelState.IsValid)
            {
                _db.Taskks.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult CompletedTasks()
        {
            IEnumerable<Taskk> objTaskList = _db.Taskks;
            return View(objTaskList);
        }

        //Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCompleted(int id)
        {
            if (_db.Taskks == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Taskks'  is null.");
            }
            var completed = await _db.Taskks.FindAsync(id);
            if (completed != null)
            {
                _db.Taskks.Remove(completed);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(CompletedTasks));
        }

    }
}
