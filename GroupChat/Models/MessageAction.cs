using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Models
{
	public class MessageAction
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[ForeignKey("Group")]
		public int GroupId { get; set; }
		public Group Group { get; set; }

		[Required]
		public int MessageId { get; set; }

		public ActionType ActionType { get; set; }

		[Required]
		public int UserId { get; set; }
		
		[ForeignKey("UserId")]
		public User User { get; set; }
	}
}
