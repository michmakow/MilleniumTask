using MilleniumRecruitmentTask.Model;

namespace MilleniumRecruitmentTask.Data.EFCore
{
    public class EfCoreValueRepository : EfCoreRepository<Value, MilleniumRecruitmentTaskContext>
    {
        public EfCoreValueRepository(MilleniumRecruitmentTaskContext context) : base(context)
        {

        }
        // We can add new methods specific to the value repository here in the future
    }
}
