using HostelApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<University> Universities { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Facilty> Facilties { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<University>().HasData(
                new University { ID = 1, Name = "Azerbaijan Technical University" }
                );

            builder.Entity<Faculty>().HasData(
                new Faculty { ID = 1, UniversityId = 1, FacultyName = "ITT" },
                 new Faculty { ID = 2, UniversityId = 1, FacultyName = "XTT" }
                );

            builder.Entity<Group>().HasData(
                new Group { ID = 1, FacultyId = 1, GroupName = "686a2" },
                new Group { ID = 2, FacultyId = 1, GroupName = "686a1" },
                 new Group { ID = 3, FacultyId = 2, GroupName = "676a2" }
                );

            builder.Entity<Slider>().HasData(
                new Slider { ID = 1, Title = "Welcome to mega hotel", Content = "Cogitavisse erant puerilis utrum efficiantur adhuc expeteretur.", Image = "slide-4.png" },
                new Slider { ID = 2, Title = "Feel like your home", Content = "Cogitavisse erant puerilis utrum efficiantur adhuc expeteretur.", Image = "slide-2.png" },
                new Slider { ID = 3, Title = "Perfect palace for dining", Content = "Cogitavisse erant puerilis utrum efficiantur adhuc expeteretur.", Image = "slide-3.png" }
                );

            builder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Deluxe" },
                new Category { Id = 2, CategoryName = "Super Deluxe" },
                new Category { Id = 3, CategoryName = "Single" }
                );

            builder.Entity<Room>().HasData(
                new Room { ID = 1, CategoryId = 2, Price = 399, Breakfast = true, BedCount = 2, WiFi = true, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. " },
                new Room { ID = 2, CategoryId = 2, Price = 299, Breakfast = true, BedCount = 4, WiFi = true, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. " },
                new Room { ID = 3, CategoryId = 2, Price = 299, Breakfast = true, BedCount = 4, WiFi = true, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. " },
                new Room { ID = 4, CategoryId = 2, Price = 289, Breakfast = true, BedCount = 2, WiFi = true, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. " },
                new Room { ID = 5, CategoryId = 2, Price = 299, Breakfast = true, BedCount = 4, WiFi = true, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. " },
                new Room { ID = 6, CategoryId = 2, Price = 279, Breakfast = true, BedCount = 4, WiFi = true, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. " },
                new Room { ID = 7, CategoryId = 2, Price = 259, Breakfast = true, BedCount = 2, WiFi = true, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. " }
                );

            builder.Entity<RoomImage>().HasData(
                new RoomImage { ID = 1, RoomId = 1, Image = "room-1.png" },
                new RoomImage { ID = 2, RoomId = 2, Image = "room-2.png" },
                new RoomImage { ID = 3, RoomId = 2, Image = "room-3.png" },
                new RoomImage { ID = 4, RoomId = 2, Image = "room-4.png" },
                new RoomImage { ID = 5, RoomId = 3, Image = "room-5.png" },
                new RoomImage { ID = 6, RoomId = 3, Image = "room-6.png" },
                new RoomImage { ID = 7, RoomId = 4, Image = "room-7.png" },
                new RoomImage { ID = 8, RoomId = 4, Image = "room-8.png" },

                new RoomImage { ID = 9, RoomId = 5, Image = "room-1.png" },
                new RoomImage { ID = 10, RoomId = 5, Image = "room-2.png" },
                new RoomImage { ID = 11, RoomId = 6, Image = "room-3.png" },
                new RoomImage { ID = 12, RoomId = 6, Image = "room-4.png" },
                new RoomImage { ID = 13, RoomId = 7, Image = "room-5.png" },
                new RoomImage { ID = 14, RoomId = 7, Image = "room-6.png" },
                new RoomImage { ID = 15, RoomId = 1, Image = "room-7.png" },
                new RoomImage { ID = 16, RoomId = 5, Image = "room-8.png" }
                );

            builder.Entity<Hostel>().HasData(
                new Hostel
                {
                    ID = 1,
                    Title = "About our hostel",
                    Context = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. "
                }
                );

            builder.Entity<News>().HasData(
                new News { ID = 1, Title = "A Standard Blog Post", PublishDate = DateTime.Now, Context = "Nostram virtutem poterimus quoddam praesertim legendos libero exhorrescere saluti..." },
                new News { ID = 2, Title = "A Standard Blog Post", PublishDate = DateTime.Now, Context = "Nostram virtutem poterimus quoddam praesertim legendos libero exhorrescere saluti..." },
                new News { ID = 3, Title = "A Standard Blog Post", PublishDate = DateTime.Now, Context = "Nostram virtutem poterimus quoddam praesertim legendos libero exhorrescere saluti..." }
                );

            builder.Entity<Facilty>().HasData(
                new Facilty { ID = 1, Title = "24-hour reseption", Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum." },
                new Facilty { ID = 2, Title = "Room service", Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum." },
                new Facilty { ID = 3, Title = "Car hire", Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum." },
                new Facilty { ID = 4, Title = "Wake-up call", Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum." },
                new Facilty { ID = 5, Title = "Coffe and tea", Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum." },
                new Facilty { ID = 6, Title = "Free wifi", Context = "Didicisset labore vitium referenda labor peccant integre turpe est tantopere, eius defuturum sua dolorum." }
                );

            builder.Entity<Partner>().HasData(
                new Partner { ID = 1, Name = "Vintage", Logo = "part-logo-1.png" },
                new Partner { ID = 2, Name = "Vintage", Logo = "part-logo-2.png" },
                new Partner { ID = 3, Name = "Cahmpagne", Logo = "part-logo-3.png" },
                new Partner { ID = 4, Name = "Deligous", Logo = "part-logo-1.png" },
                new Partner { ID = 5, Name = "Vintage2", Logo = "part-logo-2.png" },
                new Partner { ID = 6, Name = "Champagne", Logo = "part-logo-3.png" }
                );
        }
    }
}
