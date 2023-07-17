using System.Collections.Generic;

namespace WorkTimeApp.Entities
{
    public class Quest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<WorkTime> WorkTimes { get; set; }
    }
}
