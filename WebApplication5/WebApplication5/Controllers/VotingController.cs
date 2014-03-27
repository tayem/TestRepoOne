using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class VotingController : Controller
    {
        //
        // GET: /Voting/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Voting/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Voting/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Voting/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Voting/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Voting/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Voting/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Voting/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
