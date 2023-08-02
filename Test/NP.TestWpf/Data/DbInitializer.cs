using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Documents.DocumentStructures;
using Microsoft.EntityFrameworkCore;
using NP.DAL.Context;
using NP.DAL.Entityes;

namespace NP.TestWpf.Data
{
    public class DbInitializer
    {
        private readonly  NPDB _db;
        public DbInitializer(NPDB db)
        {
            _db = db;
        }
        public async Task InitializeAsync()
        {
            //Если он не существует БД, никаких действий не выполняется. Если она существует, база данных удаляется.
            await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);
            //Прекращаем отслеживание всех отслеживаемых в настоящее время сущностей.
            _db.ChangeTracker.Clear();
            //Мигрируем БД
            await _db.Database.MigrateAsync().ConfigureAwait(false);

            //await InitializeBreaks();
        }

        private List<BreakDbModel> Breaks; 
        private async Task InitializeBreaks()
        {
            Breaks = new List<BreakDbModel>
            {
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 05, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 06, 10, 00),},
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 06, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 07, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 07, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 08, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 08, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 09, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 09, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 10, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 10, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 11, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 11, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 12, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 12, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 13, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 13, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 14, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 14, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 15, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 15, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 16, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 16, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 17, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 17, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 18, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 18, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 19, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 19, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 20, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 20, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 21, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 21, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 22, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 22, 50, 00) ,EndBreak=new DateTime(2023, 08, 02, 23, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 02, 23, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 00, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 00, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 01, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 01, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 02, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 02, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 03, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 03, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 04, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 04, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 05, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 05, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 06, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 06, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 07, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 07, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 08, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 08, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 09, 30, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 09, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 10, 10, 00) },
                new BreakDbModel{ StartBreak=new DateTime(2023, 08, 03, 10, 50, 00) ,EndBreak=new DateTime(2023, 08, 03, 11, 30, 00) },
            };
            await _db.Breaks.AddRangeAsync(Breaks);
            await _db.SaveChangesAsync();
        }
    }
}
