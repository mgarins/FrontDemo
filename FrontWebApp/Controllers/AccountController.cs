using AutoMapper;

using FrontWebApp.Business;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontWebApp.Controllers
{
	public class AccountController : Controller
	{
		private readonly IMapper _mapper;

		public AccountController(IMapper mapper)
		{
			_mapper = mapper;
		}
		public IActionResult Index()
		{
			AccountAccess worker = new(_mapper);
			Task<IEnumerable<Models.AccountViewModel>> viewModel = worker.GetAllAccounts();

			return View("View", viewModel.Result);
		}
	}
}
