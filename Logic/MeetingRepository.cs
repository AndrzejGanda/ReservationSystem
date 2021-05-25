using ReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Logic
{
    public interface MeetingRepository
    {
        public int CreateMeeting(string name, DateTime date);
        public List<Meeting> GetAllMeetings();
        public void DeleteMeeting(int id);
        public Meeting GetMeeting(int id);
        public void UpdateMeeting(Meeting meeting, int id);
    }
}
