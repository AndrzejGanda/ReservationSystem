using ReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Logic
{
    public class BookingClient
    {
        private MeetingRepository Repository;
        
        public BookingClient(MeetingRepository repo)
        {
            Repository = repo;
        }
        public int SaveCustomer(string name, string mail, int meetingID)
        {
            var meeting = Repository.GetMeeting(meetingID);
            var participant = new Participant
            {
                Mail = mail,
                Name = name
            };
            if (meeting.Participants.Count >= 25)
            {
                throw new Exception("Participant limit is 25");
            }
            meeting.Participants.Add(participant);
            Repository.UpdateMeeting(meeting, meetingID);
            
            return meeting.Participants.Count;
        }

    }
}
