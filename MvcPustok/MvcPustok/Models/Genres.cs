using System;
namespace MvcPustok.Models
{
	public class Genres
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public List<Books> Books { get; set; }


	}
}

