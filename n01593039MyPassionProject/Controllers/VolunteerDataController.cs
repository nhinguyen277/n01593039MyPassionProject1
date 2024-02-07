﻿using n01593039MyPassionProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Diagnostics;

namespace n01593039MyPassionProject.Controllers
{
    public class VolunteerDataController : ApiController
    {
        // utilizing the database connection

        private ApplicationDbContext db = new ApplicationDbContext();

        // List Volunteer
        [HttpGet]
        [Route("api/VolunteerData/ListVolunteers")]
        public List<VolunteerDto> ListVolunteers()
        {
            List<Volunteer> Volunteers = db.Volunteers.ToList();
            List<VolunteerDto> VolunteerDtos = new List<VolunteerDto>();

            Volunteers.ForEach(b => VolunteerDtos.Add(new VolunteerDto()
            {
                VolunteerId = b.VolunteerId,
                FirstName = b.FirstName,
                LastName = b.LastName,
                ChristianName = b.ChristianName,
                PhoneNumber = b.PhoneNumber,
                Email = b.Email,
                Address = b.Address,
                GroupId = b.GroupId,
                GroupName = b.Group.GroupName,

            }));
            return VolunteerDtos;
        }


        // Find Volunteer
        // GET: api/VolunteerData/FindVolunteer/2


        [HttpGet]
        [ResponseType(typeof(VolunteerDto))]
        public IHttpActionResult FindVolunteer(int id)
        {
            {
                Volunteer Volunteer = db.Volunteers.Find(id);
                VolunteerDto VolunteerDto = new VolunteerDto()
                {
                    VolunteerId= Volunteer.VolunteerId,
                    FirstName = Volunteer.FirstName,
                    LastName = Volunteer.LastName,
                    ChristianName = Volunteer.ChristianName,
                    PhoneNumber = Volunteer.PhoneNumber,
                    Email = Volunteer.Email,
                    Address = Volunteer.Address,
                    GroupId = Volunteer.GroupId,
                    GroupName = Volunteer.Group.GroupName,
                };
                if (Volunteer == null)
                {
                    return NotFound();
                }
                return Ok(VolunteerDto);
            }
        }
            // Add Volunteer

            /// <summary>
            /// Adds a volunteer to the system
            /// </summary>
            /// <param name="Volunteer">JSON FORM DATA of a volunteer</param>
            /// <returns>
            /// HEADER: 201 (Created)
            /// CONTENT: Voluntere ID, Volunteer Data
            /// or
            /// HEADER: 400 (Bad Request)
            /// </returns>
            /// <example>
            /// POST: api/VolunteerData/AddVolunteer
            /// FORM DATA: Volunteer JSON Object
            /// </example>
            [ResponseType(typeof(Volunteer))]
            [HttpPost]
            
            public IHttpActionResult AddVolunteer(Volunteer Volunteer)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Volunteers.Add(Volunteer);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new { id = Volunteer.VolunteerId }, Volunteer);
            }
        // UpdateVolunteer
        //DeleteVolunteer

        /// <summary>
        /// Deletes an Species from the system by it's ID.
        /// </summary>
        /// <param name="id">The primary key of the Species</param>
        /// <returns>
        /// HEADER: 200 (OK)
        /// or
        /// HEADER: 404 (NOT FOUND)
        /// </returns>
        /// <example>
        /// POST: api/SpeciesData/DeleteSpecies/5
        /// FORM DATA: (empty)
        /// </example>
        [ResponseType(typeof(Volunteer))]
        [HttpPost]
        public IHttpActionResult DeleteVolunteer(int id)
        {
            Volunteer Volunteer = db.Volunteers.Find(id);
            if (Volunteer == null)
            {
                return NotFound();
            }

            db.Volunteers.Remove(Volunteer);
            db.SaveChanges();

            return Ok();
        }
        // related methods include:
        // ListVolunteerForGroup*/
    }
    }
