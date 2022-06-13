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
	[Route("Group")]
	public class GroupController : Controller
	{

		private IGroupService _groupService;
		public GroupController(IGroupService groupService)
		{
			_groupService = groupService;
		}

		[Route("add")]
		[HttpPost]
		public void PostGroup(Group group)
		{
			_groupService.AddGroup(group);
		}

		[Route("update")]
		[HttpPut]
		public void PutGroup(Group group)
		{
			_groupService.UpdateGroup(group);
		}

		[Route("{groupId}/delete")]
		[HttpPut]
		public void PutDeleteGroup(int groupId)
		{
			_groupService.DeleteGroup(groupId);
		}

		[Route("{groupId}/addmembers")]
		[HttpPost]
		public void AddGroupMembers(int groupId, List<GroupMember> members)
		{
			_groupService.AddGroupMembers(groupId, members);
		}

		[Route("{groupId}/removeuser/{userId}")]
		[HttpPut]
		public void RemoveGroupMember(int groupId, int userId)
		{
			_groupService.RemoveGroupMember(groupId, userId);
		}

	}
}
