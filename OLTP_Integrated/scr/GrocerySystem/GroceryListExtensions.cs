using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GrocerySystem.DAL;
using GrocerySystem.BLL;
#endregion


namespace GrocerySystem
{
    public static class GroceryListExtensions
    {
        public static void AddBackendDependencies(this IServiceCollection services,
              Action<DbContextOptionsBuilder> options)
        {
            //add the context class of your application library to the service collection
            //pass in the connection string options.
            services.AddDbContext<GrocerylistContext>(options);

            //add any business logic layer class to the service collection so our
            //  web app has access to the methods within the BLL class.
            services.AddTransient<PickingServices>((serviceProvider) =>
            {
                //get the dbcontext class
                var context = serviceProvider.GetRequiredService<GrocerylistContext>();
                return new PickingServices(context);
            });



        }
    }
}
