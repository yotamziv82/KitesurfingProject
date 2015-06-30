using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using KiteSurfingFinalProject.Models;

namespace KiteSurfingFinalProject.Logic
{
    internal class RoleAction // My Admin
    {

        //internal void addUserAndRole()
        //{
        //    // Access AllicationDbContext
        //    ApplicationDbContext context = new ApplicationDbContext();

        //    // Create Role and User
        //    IdentityResult idRoleResult;
        //    IdentityResult idUserResult;

        //    // Create the RoleStore<T>
        //    var roleStore = new RoleStore<IdentityRole>(context);

        //    // Create the RoleManager<T>
        //    var roleManager = new RoleManager<IdentityRole>(roleStore);

        //    // Next step - Create custom role
        //    if (!roleManager.RoleExists("WebSiteAdminRole"))
        //    {
        //        idRoleResult = roleManager.Create
        //            (new IdentityRole { Name = "WebSiteAdminRole", });
        //    }

        //    // Create UserManager object base on RoleStore object
        //    var userMgr = new UserManager<ApplicationUser>
        //    (new UserStore<ApplicationUser>(context));
        //    var appUser = new ApplicationUser
        //    {
        //        UserName = "yotamvizi",
        //        Email = "yotamziv82@gmail.com"
        //    };
        //    idUserResult = userMgr.Create(appUser, "!Pa$$w0rd");

        //    // Check if the user is in role
        //    if (!userMgr.IsInRole(userMgr.FindByEmail("yotamziv82@gmail.com").Id, "WebSiteAdminRole"))
        //    {
        //        idUserResult = userMgr.AddToRole(userMgr.FindByEmail("yotamziv82@gmail.com").Id, "WebSiteAdminRole");
        //    }


        //}
    }
}