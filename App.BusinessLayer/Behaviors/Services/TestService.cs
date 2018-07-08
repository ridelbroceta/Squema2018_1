using App.BusinessLayer.Contracts.Core;
using App.BusinessLayer.Contracts.Services;

namespace App.BusinessLayer.Behaviors.Services
{
    class TestService : ITestService
    {
        private readonly IRepository _repository;

        public TestService(IRepository repository)
        {
            _repository = repository;
        }
    }
}
