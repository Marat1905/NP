using Microsoft.Win32.SafeHandles;
using NP.ChangeSettings.Models;
using NP.ChangeSettings.Services.Interfaces;
using NP.DAL.Entityes;
using NP.DAL.Interfaces;
using NP.Infrastructure.Enums;

namespace NP.ChangeSettings.Services
{
    internal class ChangeRunSettingsService:IChangeRunSettingsService
    {
        private readonly IRepository<СhangeSettingsDbModel> repository;

        public ChangeRunSettingsService(IRepository<СhangeSettingsDbModel> repository)
        {
            this.repository = repository;
        }

        
        public IEnumerable<ChangeSettingsInfo> Period<ChangeSettingsInfo>(DateTime start, DateTime end, TimeSpan filter = default)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChangeSettingsInfo> SmenaSearch<ChangeSettingsInfo>(DateTime data, Smena smena, TimeSpan filter = default)
        {
            throw new NotImplementedException();
        }
    }
}
