using Microsoft.EntityFrameworkCore;

namespace SwimTheWorld.PlayerApi.Infrastructure;

public static class DatabaseConfigutation
{
    public static void ApplyMigrations(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<PlayerDbContext>();
        dbContext.Database.Migrate();
    }
}
