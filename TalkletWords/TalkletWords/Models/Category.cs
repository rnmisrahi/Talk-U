using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalkletWords.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Word> Words { get; set; }
    }
}
