using System;
namespace MvcPustok.Models
{
	public class BookTags
	{
		public int Id { get; set; }

		public int BookId { get; set; }

		public int TagId { get; set; }

		public Books Books { get; set; }

		public Tags Tags { get; set; }

	}
}

