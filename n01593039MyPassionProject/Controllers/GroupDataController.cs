using n01593039MyPassionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace n01593039MyPassionProject.Controllers
{
    public class GroupDataController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // List Groups
        [HttpGet]
        [Route("api/GroupData/ListGroups")]
        public List<GroupDto> ListGroups()
        {
            List<Group> Groups = db.Groups.ToList();
            List<GroupDto> GroupDtos = new List<GroupDto>();

            Groups.ForEach(b => GroupDtos.Add(new GroupDto()
            {
                GroupId = b.GroupId,
                GroupName = b.GroupName,
                Description = b.Description,

            }));
            return GroupDtos;
        }

        //[ResponseType(typeof(Group))]
    }
}
