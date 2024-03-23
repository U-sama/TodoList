using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Data.Models;

namespace TodoApi.Extentions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            using AppDbContext _db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            _db.Database.Migrate();
        }
    }
}
