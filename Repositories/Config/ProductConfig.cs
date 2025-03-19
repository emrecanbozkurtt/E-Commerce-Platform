using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
	public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{

			builder.HasKey(p => p.ProductId);
			builder.Property(p => p.ProductName).IsRequired();
			builder.Property(p => p.Price).IsRequired();

			builder.HasData(
				new Product() { ProductId = 1, CategoryId = 1, ImageUrl = "/images/1.jpg", ProductName = "Nutuk", Price = 400, ShowCase = true },
				new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/2.jpg", ProductName = "Computer", Price = 20_000, ShowCase = true },
				new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/3.jpg", ProductName = "Mouse", Price = 500, ShowCase = false },
				new Product() { ProductId = 4, CategoryId = 1, ImageUrl = "/images/4.jpg", ProductName = "When Nietzsche Wept", Price = 150, ShowCase = false },
				new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/5.jpg", ProductName = "Television", Price = 40_000, ShowCase = false },
				new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/6.jpg", ProductName = "War and Peace |-||", Price = 500, ShowCase = true },
				new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/7.jpg", ProductName = "Crime and Punishment", Price = 300, ShowCase = false },
				new Product() { ProductId = 8, CategoryId = 2, ImageUrl = "/images/8.png", ProductName = "Monster Laptop", Price = 50_000, ShowCase = true },
				new Product() { ProductId = 9, CategoryId = 2, ImageUrl = "/images/9.jpg", ProductName = "IPhone 16 Pro Max", Price = 120_000, ShowCase = true },
				new Product() { ProductId = 10, CategoryId = 2, ImageUrl = "/images/10.jpg", ProductName = "JBL Headphones", Price = 2_000, ShowCase = false },
				new Product() { ProductId = 11, CategoryId = 1, ImageUrl = "/images/11.jpg", ProductName = "The Trial", Price = 100, ShowCase = true },
				new Product() { ProductId = 12, CategoryId = 2, ImageUrl = "/images/12.png", ProductName = "Keyboard", Price = 3_000, ShowCase = false }
				);
		}
	}
}
