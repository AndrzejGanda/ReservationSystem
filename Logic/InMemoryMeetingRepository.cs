using ReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Logic
{
    public class InMemoryMeetingRepository : MeetingRepository
    {
        private List<Meeting> Meetings;

        public InMemoryMeetingRepository()
        {
            Meetings = new List<Meeting>();
        }
        public int CreateMeeting(string name, DateTime date)
        {
            var newMeeting = new Meeting
            {
                Date = date, Name = name, Id = NextID(), Participants = new List<Participant>()
            };
            Meetings.Add(newMeeting);
            return newMeeting.Id;

        }
        private int NextID()
        {
            if (Meetings.Count == 0)
            {
                return 1;
            }
            return Meetings.Max(x => x.Id) + 1;
        }
        public List<Meeting> GetAllMeetings()
        {
            return Meetings;
        }
        public void DeleteMeeting(int id)
        {
            var index = Meetings.FindIndex(x => x.Id == id);
            
            if (index != -1)
            {
                Meetings.RemoveAt(index);
            }
        }
        public Meeting GetMeeting(int id)
        {
            var index = Meetings.FindIndex( x => x.Id == id);
            if (index != -1)
            {
                return Meetings.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public void UpdateMeeting(Meeting meeting, int id)
        {
            //nothing
        }
    }

}
