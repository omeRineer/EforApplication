using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeApp.Entities
{
    public class WorkTime
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Person { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int QuestId { get; set; }
        public Quest Quest { get; set; }
    }
}
