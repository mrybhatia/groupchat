using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Models
{
	public class Group
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string GroupName { get; set; }

		[Required]
		public int CreatedBy { get; set; }

		[Required]
		public int LastUpdatedBy { get; set; }

		public DateTime CreatedOn { get; set; }
		public DateTime LastUpdatedOn { get; set; }
		public bool IsActive { get; set; }
	}
}
