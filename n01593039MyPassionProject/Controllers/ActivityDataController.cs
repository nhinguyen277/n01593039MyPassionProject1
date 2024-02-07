using n01593039MyPassionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01593039MyPassionProject.Controllers
{
    public class ActivityDataController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // List Activitys
        [HttpGet]
        [Route("api/ActivityData/ListActivities")]
        public List<ActivityDto> ListActivities()
        {
            List<Activity> Activities = db.Activities.ToList();
            List<ActivityDto> ActivityDtos = new List<ActivityDto>();

            Activities.ForEach(b => ActivityDtos.Add(new ActivityDto()
            {
                ActivityId = b.ActivityId,
                ActivityName = b.ActivityName,
                Description = b.Description,
                DateTime = b.DateTime,

            }));
            return ActivityDtos;
        }
    }
}
