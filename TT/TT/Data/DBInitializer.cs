using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT.Data;
using TT.Models;

namespace TT.Data
{
    public class DBInitializer
    {

        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Tracks.Any())
            {
                return;
            }

            var Tracks = new Track[]
            {
                new Track{Name="Chief Scientist"},
                new Track {Name="Management"},
                new Track{Name="Marketing"},
                new Track{Name="Programming"},
                new Track{Name="Other"}
            };
            foreach (Track track in Tracks)
            {
                context.Tracks.Add(track);
            }
            context.SaveChanges();
        }

    }
}
