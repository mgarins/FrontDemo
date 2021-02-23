using AutoMapper;

using FrontWebApp.Models;

using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FrontWebApp.Business
{
	public class AccountAccess
	{
		private readonly string baseUrl = "https://frontiercodingtests.azurewebsites.net/api/accounts";
		private readonly IMapper _mapper;

		public AccountAccess(IMapper mapper)
		{
			_mapper = mapper;
		}

		public async Task<IEnumerable<AccountViewModel>> GetAllAccounts()
		{
			List<AccountViewModel> retval = new();
			string url = $"{baseUrl}/getall";
			using (HttpClient client = new())
			{
				try
				{
					HttpResponseMessage response = await client.GetAsync(url);
					if (response.IsSuccessStatusCode)
					{
						string result = await response.Content.ReadAsStringAsync();
						var data = JsonSerializer.Deserialize<IEnumerable<AccountModel>>(result);
						// Do the mapping
						retval = _mapper.Map<List<AccountViewModel>>(data);
					}
					else
					{
						// Log the response status code
					}
				}
				catch (System.Exception)
				{
					// log the exception
					throw;
				}

			}
			return retval;
		}

	}
}
