using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMySQL.Models {
	public class User {
		[Key]
		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public DateTime? DateOfBirth { get; set; }
	}
}