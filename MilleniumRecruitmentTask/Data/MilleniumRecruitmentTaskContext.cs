using Microsoft.EntityFrameworkCore;
using MilleniumRecruitmentTask.Model;

namespace MilleniumRecruitmentTask.Data
{
    public class MilleniumRecruitmentTaskContext : DbContext
    {
        public MilleniumRecruitmentTaskContext (DbContextOptions<MilleniumRecruitmentTaskContext> options)
            : base(options)
        {
        }

        public DbSet<Value> Value { get; set; }
    }
}
