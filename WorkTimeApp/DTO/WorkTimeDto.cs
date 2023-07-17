using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeApp.DTO
{
    public class WorkTimeDto
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Person { get; set; }
        public string? Description { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int QuestId { get; set; }
        public string QuestName { get; set; }
        public double Amount { get; set; }
    }
}
