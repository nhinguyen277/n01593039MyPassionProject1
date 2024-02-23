using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace n01593039MyPassionProject.Models.ViewModels
{
    public class DetailsGroup
    {
        public GroupDto SelectedGroup { get; set; }
        public IEnumerable<VolunteerDto> RelatedVolunteers { get; set; }

        public IEnumerable<ActivityDto> JoinedActivities { get; set; }
    }
}