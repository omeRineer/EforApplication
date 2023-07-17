using System.Collections.Generic;

namespace WorkTimeApp.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<WorkTime> WorkTimes { get; set; }
    }
}
