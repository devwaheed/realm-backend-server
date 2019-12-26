using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace realm_backend_server
{
    public class DBSeeder
    {
        private static RBSContext RbsContext { get; set; }

        public DBSeeder(RBSContext context)
        {
            RbsContext = context;
        }

        public static void SetupRemTaskData(IApplicationBuilder app)
        {
            var taskOne = new RemTask
            {
                Title = "Setup Backend Server",
                Complete = false,
                CompletedDate = DateTime.Now
            };

            var taskTwo = new RemTask
            {
                Title = "Setup RealM Server",
                Complete = false,
                CompletedDate = DateTime.Now
            };

            var taskThree = new RemTask
            {
                Title = "Setup Mobile App",
                Complete = false,
                CompletedDate = DateTime.Now
            };

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<RBSContext>();
                context.Tasks.AddRange(taskOne, taskTwo, taskThree);
                context.SaveChanges();
            }

        }
    }
}
