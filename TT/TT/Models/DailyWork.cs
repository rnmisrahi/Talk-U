using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TT.Models
{
    public class DailyWork
    {
        public int DailyWorkId { get; set; }
        public string UserName { get; set; }
        public string Track { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Day")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime StartDate { get; set; }
        public int Minutes { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", UserName, Track, StartDate, Minutes);
        }
    }
}
