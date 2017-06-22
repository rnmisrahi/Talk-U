using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalkletWords.Data;
using TalkletWords.Models;

namespace TalkletWords.Data
{
    public class DBInitializer
    {

        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.WordTypes.Any())
            {
                return;
            }

            var WordTypes = new WordType[]
            {
                new WordType{Name="combine"},
                new WordType{Name="complexity"},
                new WordType{Name="How_use_words"},
                new WordType{Name="word"},
                new WordType{Name="word_endings"},
                new WordType{Name="word_endings_nouns"},
                new WordType{Name="word_endings_verbs"},
                new WordType{Name="word_forms_nouns"},
                new WordType{Name="word_forms_verbs"},
            };
            foreach (WordType wt in WordTypes)
            {
                context.WordTypes.Add(wt);
            }
            context.SaveChanges();
        }

    }
}
