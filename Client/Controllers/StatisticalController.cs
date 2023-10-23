using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    [Authorize]
    public class StatisticalController : Controller
    {
        // GET: StatisticalController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StatisticalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StatisticalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatisticalController/Create
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

        // GET: StatisticalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StatisticalController/Edit/5
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

        // GET: StatisticalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StatisticalController/Delete/5
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
