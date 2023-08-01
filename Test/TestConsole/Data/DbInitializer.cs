using Microsoft.EntityFrameworkCore;
using NP.DAL.Context;

namespace TestConsole.Data
{
    public class DbInitializer
    {
        private readonly NPDB _db;
        public DbInitializer(NPDB db)
        {
            _db = db;
        }
        public async Task InitializeAsync()
        {
            await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);

            await _db.Database.MigrateAsync().ConfigureAwait(false);

        }
    }
}
