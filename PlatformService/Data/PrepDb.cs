namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SpeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SpeedData(AppDbContext context)
        {
          if (!context.Profiles.Any())
            {
                Console.WriteLine("----> Seeding data...");

                context.Profiles.AddRange(
                    new Models.Profile() { Name = "John", Address = "Bucharest", Identification= "1790825417897" },
                    new Models.Profile() { Name ="Mary", Address = "Cluj", Identification = "2800812126742" },
                    new Models.Profile() { Name ="Ian", Address = "Timisoara", Identification= "1780812357662" }
                    );
                context.SaveChanges();
            }
          else
            {
                Console.WriteLine("----> We already have data");
            }
        }
    }
}
