namespace KiteSurfingFinalProject.Migrations
{
    using KiteSurfingFinalProject.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KiteSurfingFinalProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        //protected override void Seed(KiteSurfingFinalProject.Models.ApplicationDbContext context)
        //{
            
        //}

        protected override void Seed(Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var roleMng = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            ir = roleMng.Create(new IdentityRole("WebSiteAdmin"));
            var usrMangr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "yotamziv82@gmail.com",
            };
            ir = usrMangr.Create(user, "Pa$$w0rd");
            if (ir.Succeeded == false)
            {
                var t = ir.Succeeded;
            }
            ir = usrMangr.AddToRole(user.Id, "WebSiteAdmin");
            


        //    IdentityResult ir;

        //    var roleMng = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

        //    ir = roleMng.Create(new IdentityRole("WebSiteAdmin"));

        //    var userMng = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

        //    var user = new ApplicationUser()

        //    {

        //        UserName = "YotamAdmin",

        //    };

        //    ir = userMng.Create(user, "Pa$$w0rd");

        //    if (ir.Succeeded == false)
        //    {

        //        var t = ir.Succeeded;

        //    }

        //    ir = userMng.AddToRole(user.Id, "WebSiteAdmin");

        }
    }
}
