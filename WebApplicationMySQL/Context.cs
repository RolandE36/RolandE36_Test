using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplicationMySQL.Models;

namespace WebApplicationMySQL {
	public class Context : DbContext {
		public DbSet<User> Users { get; set; }
	}
}