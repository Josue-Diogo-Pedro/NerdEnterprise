using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NSE.Identidade.API.Data;

public class IdentidadeDbContext : IdentityDbContext
{
    public IdentidadeDbContext(DbContextOptions<IdentidadeDbContext> options) : base(options) { }
}
