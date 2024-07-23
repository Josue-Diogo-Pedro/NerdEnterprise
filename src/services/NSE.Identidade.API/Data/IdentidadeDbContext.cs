using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NSE.Identidade.API.Data;

public class IdentidadeDbContext : IdentityDbContext
{
    //public IdentidadeDbContext()
    //{
        
    //}
    public IdentidadeDbContext(DbContextOptions<IdentidadeDbContext> options) : base(options) { }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-3OMCEOO\\SQLEXPRESS;Initial Catalog=EnterpriseDb;Integrated Security=True; Trust Server Certificate=true;MultipleActiveResultSets=true");
    //    base.OnConfiguring(optionsBuilder);
    //}
}
