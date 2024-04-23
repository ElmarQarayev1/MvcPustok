using System;
namespace MvcPustok.Models
{
	public class BookImages
	{
		public int Id { get; set; }

		public int BookId { get; set; }

		public string Name { get; set; }

		public bool PosterStatus { get; set; }

		public Books Books { get; set; }
	}
}

