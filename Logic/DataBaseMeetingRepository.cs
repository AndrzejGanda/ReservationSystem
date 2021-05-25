using BooksApi.Models;
using MongoDB.Driver;
using ReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Logic
{
    public class DataBassMeetingRepository : MeetingRepository
    {
        private readonly IMongoCollection<Meeting> meetings;
        public DataBassMeetingRepository(IMeetingsDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            meetings = database.GetCollection<Meeting>(settings.MeetingsCollectionName);
        }
        public int CreateMeeting(string name, DateTime date)
        {
            var newMeeting = new Meeting
            {
                Date = date,
                Name = name,
                Id = NextID(),
                Participants = new List<Participant>()
            };
            meetings.InsertOne(newMeeting);
            return 0;
        }
        private int NextID()
        {
            var allMeetings = GetAllMeetings();
            if(allMeetings.Count == 0)
            {
                return 1;
            }

            var highestId = allMeetings.Max(x => x.Id);
            return highestId + 1;
        }

        public void DeleteMeeting(int id)
        {
            meetings.DeleteOne(meeting => meeting.Id == id);
        }

        public List<Meeting> GetAllMeetings()
        {
            return meetings.Find(meeting => true).ToList();
        }

        public Meeting GetMeeting(int id)
        {
            return meetings.Find(meeting => meeting.Id == id).FirstOrDefault();
        }

        public void UpdateMeeting(Meeting meeting, int id)
        {
            meetings.ReplaceOne(meeting => meeting.Id == id, meeting);
        }
    }
}
