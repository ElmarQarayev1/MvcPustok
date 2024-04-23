using System;
using Microsoft.EntityFrameworkCore;
using MvcPustok.Models;

namespace MvcPustok.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{

		}
		public DbSet<Authors> Authors { get; set; }

		public DbSet<BookImages> BookImages { get; set; }

		public DbSet<Books> Books { get; set; }

		public DbSet<BookTags> BookTags { get; set; }

		public DbSet<Genres> Genres { get; set; }

		public DbSet<Sliders> Sliders { get; set; }

		public DbSet<Tags> Tags { get; set; }
			
	}

}

