using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TT.Data;
using TT.Models;
using System.Data.Common;

namespace TT.Controllers
{
    public class DailyWorksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DailyWorksController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: DailyWorks
        public async Task<IActionResult> Index()
        {
            string sql = "Select R.UserName, T.Name as Track, CAST(R.TaskStart AS DATE) as startDate, sum(DATEDIFF(minute, R.TaskStart, TaskEnd)) as minutes " +
                  "from Record[R] Join Track[T] ON R.TrackId = T.TrackId " +
                  "WHERE YEAR(R.TaskEnd) >= 2000 " +
                  "GROUP BY R.UserName, T.Name, CAST(R.TaskStart AS DATE)";
            List<DailyWork> works = new List<DailyWork>();
            var conn = _context.Database.GetDbConnection();
            try
            {
                await conn.OpenAsync();
                using(var command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    DbDataReader reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            var row = new DailyWork { UserName = reader.GetString(0), Track = reader.GetString(1), StartDate = reader.GetDateTime(2), Minutes = reader.GetInt32(3) };
                            works.Add(row);
                        }
                    }
                    reader.Dispose();
                }
            }
            finally
            {
                conn.Close();
            }

            return View(works.ToList());
        }

    }
}
