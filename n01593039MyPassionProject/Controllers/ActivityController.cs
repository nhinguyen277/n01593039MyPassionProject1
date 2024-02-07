using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using System.Net.Http;
using n01593039MyPassionProject.Models;

namespace n01593039MyPassionProject.Controllers
{
    public class ActivityController : Controller
    {
        // GET: Activity/List
        // Objective: a webpage that lists the Activities in our system
        public ActionResult List()
        {
            // get Activity data through an Http request
            // GET {resource}/api/activitydata/listactivities
            //https://localhost:44375/api/activitydata/listactivities
            // use Http client to access the information

            HttpClient client = new HttpClient();
            //set the url
            string url = "https://localhost:44375/api/activitydata/listactivities";
            HttpResponseMessage response = client.GetAsync(url).Result;
            List<ActivityDto> Activities = response.Content.ReadAsAsync<List<ActivityDto>>().Result;

            // Views/Volunteers/List.cshtml
            return View(Activities);
        }
    }
}