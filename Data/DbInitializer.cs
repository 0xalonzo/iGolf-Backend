using IgolfBackend.Models;
using System.Linq;

namespace IgolfBackend.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GolfContext context)
        {
            context.Database.EnsureCreated();

            // Look for any courses.
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

            var courses = new Course[]
            {
                new Course{Name="Pebble Beach Golf Links", State="california", Location="Monterey County", Holes=18, Par=72, Designer="Jack Neville & Douglas Grant", Rating=4.9},
                new Course{Name="Torrey Pines Golf Course", State="california", Location="San Diego", Holes=36, Par=72, Designer="William P. Bell", Rating=4.8},
                new Course{Name="TPC Harding Park", State="california", Location="San Francisco", Holes=18, Par=72, Designer="Willie Watson & Sam Whiting", Rating=4.7},
                new Course{Name="Bethpage Black Course", State="new-york", Location="Nassau County", Holes=18, Par=71, Designer="A.W. Tillinghast", Rating=4.8},
                new Course{Name="Winged Foot Golf Club", State="new-york", Location="Westchester County", Holes=36, Par=72, Designer="A.W. Tillinghast", Rating=4.9},
                new Course{Name="Shinnecock Hills Golf Club", State="new-york", Location="Suffolk County", Holes=18, Par=70, Designer="William Flynn & Howard Toomey", Rating=4.9},
                new Course{Name="Augusta National Golf Club", State="georgia", Location="Augusta", Holes=18, Par=72, Designer="Alister MacKenzie & Bobby Jones", Rating=4.9},
                new Course{Name="Pinehurst No. 2", State="north-carolina", Location="Pinehurst", Holes=18, Par=72, Designer="Donald Ross", Rating=4.8},
                new Course{Name="Whistling Straits", State="wisconsin", Location="Sheboygan", Holes=36, Par=72, Designer="Pete Dye", Rating=4.7},
                new Course{Name="Kiawah Island Golf Resort - Ocean Course", State="south-carolina", Location="Kiawah Island", Holes=18, Par=72, Designer="Pete Dye", Rating=4.8},
                new Course{Name="Royal County Down Golf Club", State="northern-ireland", Location="Newcastle", Holes=18, Par=71, Designer="Old Tom Morris & Harry Vardon", Rating=4.9},
                new Course{Name="St. Andrews Links - Old Course", State="scotland", Location="St Andrews", Holes=18, Par=72, Designer="Unknown", Rating=4.9},
                new Course{Name="Cypress Point Club", State="california", Location="Pebble Beach", Holes=18, Par=72, Designer="Alister MacKenzie & Robert Hunter", Rating=4.9},
                new Course{Name="Merion Golf Club", State="pennsylvania", Location="Ardmore", Holes=18, Par=70, Designer="Hugh Wilson", Rating=4.8},
                new Course{Name="Muirfield Village Golf Club", State="ohio", Location="Dublin", Holes=18, Par=72, Designer="Jack Nicklaus", Rating=4.7}
            };

            foreach (var course in courses)
            {
                context.Courses.Add(course);
            }
            context.SaveChanges();
        }
    }
}
