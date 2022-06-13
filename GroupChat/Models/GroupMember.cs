using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Models
{
	public class GroupMember
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[ForeignKey("Group")]
		public int GroupId { get; set; }
		public Group Group { get; set; }

		[Required]
		public int UserId { get; set; }

		[Required]
		public int CreatedBy { get; set; }

		[Required]
		public int LastUpdatedBy { get; set; }

		public DateTime LastUpdatedOn { get; set; }
		public bool IsActive { get; set; }

		[ForeignKey("UserId")]
		public User User { get; set; }
	}
}
