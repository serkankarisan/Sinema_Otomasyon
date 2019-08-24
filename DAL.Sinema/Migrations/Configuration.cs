namespace DAL.Sinema.Migrations
{
    using Entities.Sinema.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Sinema.Context.SinemaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DAL.Sinema.Context.SinemaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            //þifre 12345
            context.Users.AddOrUpdate(
                new User { Id = 1, UserName = "serkan", Name = "Serkan", SurName = "Karýþan", IsActive = true, Password = "NieQminDE4Ggcewn98nKl3Jhgq7Smn3dLlQ1MyLPswq7njpt8qwsIP4jQ2MR1nhWTQyNMFkwV19g4tPQSBhNeQ==", AddedDate = DateTime.Now, RoleId=1}
                );
            context.Roles.AddOrUpdate(
                new Role { Id = 1, RoleName = "Admin", AddedDate=DateTime.Now, IsActive=true }, new Role { Id = 2, RoleName = "User", AddedDate = DateTime.Now, IsActive = true }
               );
        }
    }
}
