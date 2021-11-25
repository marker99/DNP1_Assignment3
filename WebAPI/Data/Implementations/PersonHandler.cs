using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using WebAPI.FileData;
using WebAPI.Persistence;

namespace WebAPI.Data.Implementations
{
    public class PersonHandler : IPersonHandler
    {
        private AdultDBContext _adultDbContext;
        private static FileContext _fileContext;

        public PersonHandler(AdultDBContext _adultDbContext)
        {
            _fileContext = new();
            this._adultDbContext = _adultDbContext;
        }

        public async Task NewAdultAsync(Adult newAdult)
        {
            int maxId = _adultDbContext.Adults.Max(a => a.Id);
            newAdult.Id = maxId + 1;
            await _adultDbContext.Adults.AddAsync(newAdult);
            await _adultDbContext.SaveChangesAsync();
        }

        public async Task RemoveAdultAsync(int id)
        {
            Adult toDelete = _adultDbContext.Adults.FirstOrDefault(a => a.Id == id);
            if (toDelete != null)
            {
                _adultDbContext.Adults.Remove(toDelete);
                await _adultDbContext.SaveChangesAsync();
            }
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            return _adultDbContext.Adults.FirstOrDefault(a => a.Id == id);
        }

        public async Task UpdateAdultAsync(Adult updatedAdult)
        {
            Adult a = _adultDbContext.Adults.FirstOrDefault(a => a.Id == updatedAdult.Id);
            if (a == null)
            {
                await NewAdultAsync(updatedAdult);
            }
            else
            {
                await UpdateNonMatching(a, updatedAdult);
            }

            await _adultDbContext.SaveChangesAsync();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            return await _adultDbContext.Adults.ToListAsync();
        }

        // Helper Methods

        // Updating each individual property for an Adult
        // This all works due to C# being Pass-By-Reference
        private async Task UpdateNonMatching(Adult oldA, Adult newA)
        {
            oldA.FirstName = newA.FirstName;
            oldA.LastName = newA.LastName;
            oldA.Age = newA.Age;
            oldA.Sex = newA.Sex;
            oldA.Job = newA.Job;
            oldA.HairColor = newA.HairColor;
            oldA.EyeColor = newA.EyeColor;
            oldA.Height = newA.Height;
            oldA.Weight = newA.Weight;
        }
    }
}