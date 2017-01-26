using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1 {
	public class Context : DbContext {

		public Context() : base("MYSQLCONNSTR_localdb") {
			Configuration.LazyLoadingEnabled = true;
		}

		public DbSet<User> Users { get; set; }
	}
}