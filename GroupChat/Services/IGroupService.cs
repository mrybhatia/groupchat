using GroupChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Services
{
	public interface IGroupService
	{
		void AddGroup(Group group);
		bool UpdateGroup(Group group);
		void AddGroupMembers(int groupId, List<GroupMember> member);
		void RemoveGroupMember(int groupId, int userId);
		void DeleteGroup(int groupId);
	}
}
