using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
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
			if (a == null)
			{ // Does not Exist
			  // Add new Adult
				await _adultDbContext.AddAsync<Adult>(updatedAdult);
			}
			else
			{ // Does Exist
			  // Update already existing adult
				_adultDbContext.Update<Adult>(a).CurrentValues.SetValues(updatedAdult);
			}
			await _adultDbContext.SaveChangesAsync();
		}

		public async Task<IList<Adult>> GetAdultsAsync()
		{
			return await _adultDbContext.Adults.Include(a => a.Job).ToListAsync();
		}

	}
}