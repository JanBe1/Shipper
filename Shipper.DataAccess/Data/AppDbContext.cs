using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.CodeDom;

namespace Shipper.Data
{
    public class AppDbContext : IdentityDbContext<Models.Model.User>
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
    }
}
