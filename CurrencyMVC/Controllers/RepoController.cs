using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CurrencyMVC.Models;

namespace CurrencyMVC.Controllers
{
    public class RepoController : Controller
    {
        // GET: Repo
        public ActionResult Index([FromServices] CurrencyRepo repo)
        {
            repo.AddCoin(new Penny());
            return View(repo.Coins);
        }

        // GET: Repo/Details/5
        public ActionResult Details(int id,[FromServices] CurrencyRepo repo)
        {
            return View(repo.Coins[id]);
        }

        // GET: Repo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Repo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Repo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Repo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Repo/Delete/5
        public ActionResult Delete(string id, [FromServices] CurrencyRepo repo)
        {
            return View((USCoin)repo.Coins.Find(c => c.Name == id));
        }

        // POST: Repo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}