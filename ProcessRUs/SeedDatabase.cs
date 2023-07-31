global using ProcessRUs.Models;

namespace ProcessRUs;

public class SeedDb
{
    public static async Task SeedDatabase(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        var roles = new[] { "FrontOffice", "BackOffice", "Admin" };
        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        
    }
}

