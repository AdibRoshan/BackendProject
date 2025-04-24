using BackendProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.AppdbContext
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base	(options) { }
		public DbSet<User> users { get; set; }
		public DbSet<Product> products { get; set; }
		public DbSet<Category> Category { get; set; }
		public DbSet<Cart>	carts { get; set; }
		public DbSet<CartItems> cartItems { get; set; }
		public DbSet<WishList> wishList { get; set; }

		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItems> OrderItems { get; set; }
		public DbSet<Address> Addresses { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()  
				.Property(x => x.Role)
				.HasDefaultValue("user");
			modelBuilder.Entity<User>()
				.Property(x => x.IsBlocked)
				.HasDefaultValue("false");
			modelBuilder.Entity<Category>()
				.HasMany(x => x.products)
				.WithOne(r => r.category)
				.HasForeignKey(x => x.CategoryId);
			modelBuilder.Entity<Product>()
				.Property(pr => pr.Price).
				HasPrecision(18, 2);
			modelBuilder.Entity<Product>().HasData(
new Product { ProductId = 1 , Title = "Nissan Gtr R34" , Description = "The Hot Wheels Nissan GT-R R34 is a detailed 1:64 scale die-cast model" , Price = 700 , Image = "https://example.com/gtr.jpg" , stock = 20 , CategoryId = 1 } ,
new Product { ProductId = 2 , Title = "Matchbox Jeep 4x4" , Description = "A rugged 4x4 model great for all terrains, with a realistic design." , Price = 250 , Image = "https://example.com/jeep4x4.jpg" , stock = 50 , CategoryId = 2 } ,
new Product { ProductId = 3 , Title = "LEGO Ferrari F8" , Description = "LEGO model of the Ferrari F8 with buildable parts." , Price = 1200 , Image = "https://example.com/lego-f8.jpg" , stock = 10 , CategoryId = 3 } ,
new Product { ProductId = 4 , Title = "1967 Chevy Impala" , Description = "Classic die-cast model of the '67 Impala." , Price = 850 , Image = "https://example.com/chevy67.jpg" , stock = 25 , CategoryId = 4 } ,
new Product { ProductId = 5 , Title = "Nissan Silvia S15" , Description = "JDM icon with detailed paint and decals." , Price = 950 , Image = "https://example.com/silvia-s15.jpg" , stock = 18 , CategoryId = 5 } ,
new Product { ProductId = 6 , Title = "Lamborghini Aventador" , Description = "Supercar model in stunning yellow finish." , Price = 1300 , Image = "https://example.com/lamborghini.jpg" , stock = 14 , CategoryId = 6 } ,
new Product { ProductId = 7 , Title = "Dodge Challenger SRT" , Description = "Muscle car legend, bulky and powerful." , Price = 890 , Image = "https://example.com/dodge.jpg" , stock = 30 , CategoryId = 7 } ,
new Product { ProductId = 8 , Title = "Volkswagen Beetle 1960" , Description = "Vintage charm with realistic curves and wheels." , Price = 600 , Image = "https://example.com/beetle.jpg" , stock = 40 , CategoryId = 8 } ,
new Product { ProductId = 9 , Title = "Hot Wheels Bugatti Chiron" , Description = "A sleek blue Bugatti die-cast toy from Hot Wheels." , Price = 750 , Image = "https://example.com/bugatti.jpg" , stock = 20 , CategoryId = 1 } ,
new Product { ProductId = 10 , Title = "Matchbox Rescue Truck" , Description = "Fire & rescue truck with moveable parts." , Price = 300 , Image = "https://example.com/rescue.jpg" , stock = 35 , CategoryId = 2 } ,
new Product { ProductId = 11 , Title = "LEGO Technic McLaren" , Description = "A complex build of the McLaren racing car." , Price = 1500 , Image = "https://example.com/mclaren.jpg" , stock = 8 , CategoryId = 3 } ,
new Product { ProductId = 12 , Title = "Ford Mustang GT 1969" , Description = "Classic Mustang GT in matte black." , Price = 1000 , Image = "https://example.com/mustang69.jpg" , stock = 22 , CategoryId = 4 } ,
new Product { ProductId = 13 , Title = "Toyota Supra MK4" , Description = "Detailed JDM favorite in orange." , Price = 980 , Image = "https://example.com/supra.jpg" , stock = 15 , CategoryId = 5 } ,
new Product { ProductId = 14 , Title = "Pagani Huayra" , Description = "Super detailed supercar model." , Price = 1400 , Image = "https://example.com/pagani.jpg" , stock = 12 , CategoryId = 6 } ,
new Product { ProductId = 15 , Title = "Chevrolet Camaro ZL1" , Description = "Bright orange muscle car with black stripes." , Price = 820 , Image = "https://example.com/camaro.jpg" , stock = 28 , CategoryId = 7 } ,
new Product { ProductId = 16 , Title = "Mini Cooper Classic" , Description = "Vintage Mini Cooper with UK flag top." , Price = 700 , Image = "https://example.com/mini.jpg" , stock = 19 , CategoryId = 8 } ,
new Product { ProductId = 17 , Title = "Hot Wheels Tesla Roadster" , Description = "Electric performance in die-cast form." , Price = 680 , Image = "https://example.com/tesla.jpg" , stock = 20 , CategoryId = 1 } ,
new Product { ProductId = 18 , Title = "Matchbox Police Cruiser" , Description = "Detailed black-and-white police car." , Price = 320 , Image = "https://example.com/police.jpg" , stock = 40 , CategoryId = 2 } ,
new Product { ProductId = 19 , Title = "LEGO Porsche 911 RSR" , Description = "Iconic Porsche built from LEGO bricks." , Price = 1350 , Image = "https://example.com/porsche-lego.jpg" , stock = 9 , CategoryId = 3 } ,
new Product { ProductId = 20 , Title = "Cadillac Eldorado 1959" , Description = "Vintage fins and chrome in this die-cast classic." , Price = 950 , Image = "https://example.com/eldorado.jpg" , stock = 16 , CategoryId = 4 }
                );
			modelBuilder.Entity<Category>().HasData(
	new Category { CategoryId = 1 , Name = "HotWheels" } ,
    new Category { CategoryId = 2 , Name = "Matchbox" } ,
    new Category { CategoryId = 3 , Name = "LEGO Cars" } ,
    new Category { CategoryId = 4 , Name = "Die-Cast Classics" } ,
    new Category { CategoryId = 5 , Name = "JDM Legends" } ,
    new Category { CategoryId = 6 , Name = "Supercars" } ,
    new Category { CategoryId = 7 , Name = "Muscle Cars" } ,
    new Category { CategoryId = 8 , Name = "Vintage Cars" }
                );
			
			modelBuilder.Entity<User>()
				.HasOne(x => x.Cart)
				.WithOne(y => y.User)
				.HasForeignKey<Cart>(x => x.UserId);
			modelBuilder.Entity<Cart>()
				.HasMany(q => q.cartitems)
				.WithOne(w => w.Cart)
				.HasForeignKey(i => i.CartId);
			modelBuilder.Entity<CartItems>()
				.HasOne(f=>f.Product)
				.WithMany(o=>o.CartItems)
				.HasForeignKey(i => i.ProductId);
			modelBuilder.Entity<WishList>()
				.HasOne(x => x.users)
				.WithMany(w => w.WishList)
				.HasForeignKey(e => e.UserId);
			modelBuilder.Entity<WishList>()
				.HasOne(x => x.products)
				.WithMany()
				.HasForeignKey(e => e.ProductId);
			modelBuilder.Entity<Order>()
				.HasOne(x=>x.User)
				.WithMany(o=>o.Orders)
				.HasForeignKey(e => e.UserId);
			modelBuilder.Entity<Order>()
				.Property(x => x.Status)
				.HasDefaultValue("placed"); 
			modelBuilder.Entity<OrderItems>()
				.HasOne(p => p.Order)
				.WithMany(c => c.OrderItems)
				.HasForeignKey(d => d.OrderId);
			modelBuilder.Entity<OrderItems>()
				.HasOne(x => x.Product)
				.WithMany()
				.HasForeignKey(p => p.productId);
			modelBuilder.Entity<Address>()
				.HasOne(a => a.User)
				.WithMany(u => u.Addresses)
				.HasForeignKey(u => u.UserId);
			modelBuilder.Entity<Order>()
				.HasOne(o => o.Address)
				.WithMany(a => a.Orders)
				.HasForeignKey(u => u.AddressId)
				.OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User> ( ).HasData (
                new User { Id = 2 , UserName = "Roshan" , Email = "roshan@gmail.com" , Password = "$2a$12$VPH.AgRYn10oZFsyAELKLuLs5tmO6ju3W0zWdizRqU7hnJESFtNWG" , Role = "Admin" }
                );
            }
	}
}
