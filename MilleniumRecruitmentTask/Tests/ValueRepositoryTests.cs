using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilleniumRecruitmentTask.Data.EFCore;
using MilleniumRecruitmentTask.Model;
using Xunit;

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


        [Fact]
        public void CanEntityBeAdded(Value value)
        {
            //TODO
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void CanEntityBeGetById(int id)
        {
            //TODO
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void CanEntityBeUpdated(int id, Value value)
        {
            //TODO
            //Arrange

            //Act

            //Assert
        }

        [Fact]
        public void CanEntityBeDeletedBtId(int id)
        {
            //TODO
            //Arrange

            //Act

            //Assert
        }
    }
}
