using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
