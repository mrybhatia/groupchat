using GroupChat.Data;
using GroupChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Services
{
	public class GroupService: IGroupService
	{
		private AppDBContext _context;
		public GroupService(AppDBContext context)
		{
			_context = context;
		}

		public void AddGroup(Group group){
			_context.Groups.Add(group);
			_context.SaveChanges();
		}

		public bool UpdateGroup(Group group){
			var existingGroup = _context.Groups.SingleOrDefault(g => g.Id == group.Id);
			if(existingGroup != null)
			{
				existingGroup.GroupName = group.GroupName;
				return _context.SaveChanges() > 0;
			}

			return false;
		}

		public void AddGroupMembers(int groupId, List<GroupMember> members)
		{
			var exitingMembers = _context.GroupMembers.Where(m => m.GroupId == groupId && m.IsActive == true).ToList();
			var membersToAdd = new List<GroupMember>();
			foreach(var member in members)
			{
				var isMemberExists = members.Any(m => m.UserId == member.UserId);
				if (!isMemberExists)
				{
					membersToAdd.Add(member);
				}
			}

			if(membersToAdd.Count() > 0)
			{
				_context.GroupMembers.AddRange(membersToAdd);
				_context.SaveChanges();
			}
		}

		public void RemoveGroupMember(int groupId, int userId)
		{
			var existingMember = _context.GroupMembers.SingleOrDefault(m => m.GroupId == groupId && m.UserId == userId);
			if (existingMember != null)
			{
				existingMember.IsActive = false;
				_context.SaveChanges();
			}
		}

		public void DeleteGroup(int groupId)
		{
			var existingGroup = _context.Groups.SingleOrDefault(m => m.Id == groupId);
			if(existingGroup != null)
			{
				existingGroup.IsActive = true;
				_context.SaveChanges();
			}
		}
	}
}
