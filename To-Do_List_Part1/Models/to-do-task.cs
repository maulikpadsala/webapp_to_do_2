using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace To_Do_List_Part1.Models
{
    public class to_do_task
    {
        [Key]
        public int taskId { get; set; }

        public string UserEmail { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Added_Date { get; set; }

        public DateTime Due_Date { get; set; }

        public bool Done { get; set; }

        public DateTime Done_Date { get; set; }

    }
}
