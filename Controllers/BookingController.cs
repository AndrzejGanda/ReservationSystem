using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationSystem.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private BookingClient Booking;

        public BookingController(BookingClient custormer)
        {
            Booking = custormer;
        }
        [HttpPost]
        public IActionResult BookingMeeting(string name, string mail, int id)
        {
            try
            {
                var customerCount = Booking.SaveCustomer(name, mail, id);
                return Ok(customerCount);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }


}
