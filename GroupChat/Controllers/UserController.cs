using GroupChat.Data;
using GroupChat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Controllers
{
	[Route("user")]
	public class UserController : Controller
	{

		private AppDBContext _context;
		public UserController(AppDBContext context)
		{
			_context = context;
		}

	}
}
