using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Models
{
	public class User
	{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [Required]
		public int CreatedBy { get; set; }

		[Required]
		public int LastUpdatedBy { get; set; }

		public DateTime LastUpdatedOn { get; set; }
		public bool IsActive { get; set; }

    }
}
