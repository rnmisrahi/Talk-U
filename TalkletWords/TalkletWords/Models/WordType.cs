﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalkletWords.Models
{
    public class WordType
    {
        public int WordTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Word> Words { get; set; }
    }
}
