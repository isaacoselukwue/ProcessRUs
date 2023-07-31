global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore;

namespace ProcessRUs.Models;

public class User : IdentityUser
{
}

public class ProcessRUsDbContext : IdentityDbContext<User, IdentityRole, string>
{
    public ProcessRUsDbContext(DbContextOptions<ProcessRUsDbContext> options) : base(options)
    {
    }
}
