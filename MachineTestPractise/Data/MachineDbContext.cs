using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MachineTestPractise.Data
{
    public class MachineDbContext : IdentityDbContext<IdentityUser>
    {
        public MachineDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
