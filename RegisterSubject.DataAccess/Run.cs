using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace RegisterSubject.DataAccess
{
    public class Run
    {
        public Run()
        {
            var service = new ServiceCollection()
                .AddDbContext<DbContextRAE>(options =>
                    options.UseSqlServer("tu_cadena_de_conexion"))
                .BuildServiceProvider();

            using (var scope = service.CreateScope())
            {
                var context  = scope.ServiceProvider.GetRequiredService<DbContextRAE>();
                context.Database.Migrate();
            }
        }
    }
}
