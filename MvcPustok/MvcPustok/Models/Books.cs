using System;
namespace MvcPustok.Models
{
	public class Books
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Desc { get; set; }

		public decimal CostPrice { get; set; }

		public decimal SalePrice { get; set; }

		public decimal DiscountPercent { get; set; }

		public int AuthorId { get; set; }

		public int GenreId {get;set;}

		public bool StockStatus { get; set; }

		public Authors Authors { get; set; }

		public Genres Genres { get; set; }

		public List<BookImages> BookImages { get; set; }
	}
}

