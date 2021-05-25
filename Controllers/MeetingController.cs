using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationSystem.Logic;
using ReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private MeetingRepository Repository;
        
        public MeetingController(MeetingRepository repository)
        {
            Repository = repository;
        }
        
        [HttpGet("meetings")]
        public List<Meeting> GetMeetings()
        {

            return Repository.GetAllMeetings();
        }
        [HttpPost("meetings")]
        public int NewMeeting(DateTime time, string name)
        {
            return Repository.CreateMeeting(name, time);
        }
        [HttpDelete("meetings/{id}")]
        public void DeleteMeeting(int id)
        {
            Repository.DeleteMeeting(id);
        }        
    }

    
}
