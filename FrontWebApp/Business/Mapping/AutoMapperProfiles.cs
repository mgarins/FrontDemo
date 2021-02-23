using AutoMapper;

using FrontWebApp.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontWebApp.Business.Mapping
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<AccountModel, AccountViewModel>()
				.ForMember(d => d.PhoneNumber, d => d.MapFrom(x => Convert.ToInt64(x.PhoneNumber)))
				.ForMember(d => d.Name, d => d.MapFrom(x => string.Format("{0}, {1}", x.LastName, x.FirstName)));
		}
	}
}
