using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace ddac.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ddacContext(

           serviceProvider.GetRequiredService<DbContextOptions<ddacContext>>
           ()))
            {
                // Look for any hotel.
                if (context.Hotel.Any())
                {
                    return; // DB has been seeded
                }
                context.Hotel.AddRange(
                new Hotel
                {
                    HotelName = "Chrysanthemum",
                    HotelPrice = 2.49M,
                    HDateCheckInDate = DateTime.Parse("2018-2-12"),
                    HDateCheckOutDate = DateTime.Parse("2018-2-19"),
                    HQty = 6,
                   
                },
                new Hotel
                {
                    HotelName = "Chrystal Beach",
                    HotelPrice = 29M,
                    HDateCheckInDate = DateTime.Parse("2018-2-11"),
                    HDateCheckOutDate = DateTime.Parse("2018-2-16"),
                    HQty = 4,
                }
                );
                context.SaveChanges();
            }
        }
    }
}