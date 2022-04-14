using Microsoft.EntityFrameworkCore;
using EngChallenge.Data.Models;

namespace EngChallenge.Entities
{
    public class EngChallengeContext : DbContext
    {
        public EngChallengeContext (DbContextOptions<EngChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<UserModel> User { get; set; }
    }
}
