using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalkletWords.Models
{
    public class WordData
    {
        public int WordDataId { get; set; }
        public int Months { get; set; }
        public int WordId { get; set; }
        public float Percentile { get; set; }

        public virtual Word Word { get; set; }
    }
}
