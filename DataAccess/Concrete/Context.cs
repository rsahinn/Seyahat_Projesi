using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"server=LAPTOP-50JMF0LV\SQLEXPRESS; database=TraversalDb2; integrated security=true");
		}
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2s { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Highlights> Highlights { get; set; }
        public DbSet<Highlights2> Highlights2 { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<TestiMonial> TestiMonials { get; set; }
    }

}
