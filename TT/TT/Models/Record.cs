using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TT.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public string UserName { get; set; }
        public int TrackId { get; set; }
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Start")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime TaskStart { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Ended")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime TaskEnd { get; set; }

        public virtual Track Task { get; set; }
        public virtual Boolean IsActive
        {
            get
            {
                return ((TaskStart.Year > 2000) && (TaskEnd.Year < 2000));
            }
        }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:HH:mm:ss")]
        [DisplayFormat(DataFormatString = @"{0:HH:mm}", ApplyFormatInEditMode = true)]
        public virtual TimeSpan Duration
        {
            get
            {
                TimeSpan ts = TaskEnd - TaskStart;
                return ts;
            }
        }
        //public Track Track { get; set; }
    }
}

