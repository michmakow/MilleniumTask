using Microsoft.AspNetCore.Mvc;
using MilleniumRecruitmentTask.Data.EFCore;
using MilleniumRecruitmentTask.Model;

namespace MilleniumRecruitmentTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyMDBController<Value, EfCoreValueRepository>
    {
        public MoviesController(EfCoreValueRepository repository) : base(repository)
        {

        }
    }
}
