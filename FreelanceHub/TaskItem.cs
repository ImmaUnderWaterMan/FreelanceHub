using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceHub
{
    public class TaskItem
    {
        public string Description { get; set; }
        public TimeSpan ElapsedTime { get; set; }

        public TaskItem(string description)
        {
            Description = description;
            ElapsedTime = TimeSpan.Zero;
        }

        public override string ToString()
        {
            return $"{Description} - Затраченное время: {ElapsedTime.ToString(@"hh\:mm\:ss\.ff")}";
        }
    }

}
