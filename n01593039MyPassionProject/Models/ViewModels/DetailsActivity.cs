﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace n01593039MyPassionProject.Models.ViewModels
{
    public class DetailsActivity
    {
        public ActivityDto SelectedActivity { get; set; }

        public IEnumerable<GroupDto> ResponsibleGroups { get; set; }

        public IEnumerable<GroupDto> AvailableGroups { get; set; }
        
    }
}