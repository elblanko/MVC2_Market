namespace MVC2_Market.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC2_Market.Models.MVC2_MarketContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
            //HABILITAR TRUNCATE DE DATOS
            AutomaticMigrationDataLossAllowed = true;

            ContextKey = "MVC2_Market.Models.MVC2_MarketContext";
        }

        protected override void Seed(MVC2_Market.Models.MVC2_MarketContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
