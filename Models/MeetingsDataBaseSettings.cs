using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Models
{
    public class MeetingsDataBaseSettings : IMeetingsDataBaseSettings
    {
        public string MeetingsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IMeetingsDataBaseSettings
    {
        string MeetingsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
