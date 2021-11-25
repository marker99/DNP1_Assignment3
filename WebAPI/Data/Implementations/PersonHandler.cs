using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using WebAPI.Persistence;

namespace WebAPI.Data.Implementations
{
	public class PersonHandler : IPersonHandler
	{
		private static AdultDBContext _adultDbContext;
		//private static FileContext _fileContext;

		public PersonHandler()
		{
			//_fileContext = new();
			_adultDbContext = new();
		}

		// Deprecated
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
			Adult a = await _adultDbContext.FindAsync<Adult>(updatedAdult.Id);
			//Adult a = _adultDbContext.Adults.FirstOrDefault(a => a.Id == updatedAdult.Id);
			if (a == null)
			{
				if (await _adultDbContext.Jobs.ContainsAsync(updatedAdult.Job))
				{

				}
					await _adultDbContext.AddAsync<Adult>(updatedAdult);
				//await NewAdultAsync(updatedAdult);
			}
			else
			{
				_adultDbContext.Update<Adult>(a).CurrentValues.SetValues(updatedAdult);
				//await UpdateNonMatching(a, updatedAdult);
			}

			await _adultDbContext.SaveChangesAsync();
		}

		public async Task<IList<Adult>> GetAdultsAsync()
		{
			return await _adultDbContext.Adults.Include(a => a.Job).ToListAsync();
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