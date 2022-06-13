using GroupChat.Data;
using GroupChat.Models;
using GroupChat.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Controllers
{
	[Route("Messages")]
	public class MessageController : Controller
	{
		private IGroupService _groupService;
		public MessageController(IGroupService groupService)
		{
			_groupService = groupService;
		}
	}
}
