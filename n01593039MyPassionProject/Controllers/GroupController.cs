using n01593039MyPassionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using System.Net.Http;

namespace n01593039MyPassionProject.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group/List
        // Objective: a webpage that lists the groups of volunteers in our system
        public ActionResult List()
        {
            // get group data through an Http request
            // GET {resource}/api/groupdata/listgroups
            //https://localhost:44375/api/groupdata/listgroups
            // use Http client to access the information

            HttpClient client = new HttpClient();
            //set the url
            string url = "https://localhost:44375/api/groupdata/listgroups";
            HttpResponseMessage response = client.GetAsync(url).Result;
            List<GroupDto> Groups = response.Content.ReadAsAsync<List<GroupDto>>().Result;

            // Views/Volunteers/List.cshtml
            return View(Groups);
        }

// GET: Group/Details/5
public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Group/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Group/Create
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

        // GET: Group/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Group/Edit/5
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

        // GET: Group/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Group/Delete/5
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
