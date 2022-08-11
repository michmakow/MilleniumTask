using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilleniumRecruitmentTask.Data.EFCore;

namespace MilleniumRecruitmentTask.Tests
{
    [TestClass]
    public class ValueRepositoryTests
    {
        private readonly EfCoreValueRepository valueRepository;

        public ValueRepositoryTests()
        {
            var services = new ServiceCollection();
            services.AddTransient<EfCoreValueRepository>();

            var serviceProvider = services.BuildServiceProvider();

            valueRepository = serviceProvider.GetService<EfCoreValueRepository>();         
        }      
    }
}
