using Business.Interfaces;
using Model;
using System;
using TestManager.Interfaces;

namespace Business
{
    public class TestManagerDomain : ITestManagerDomain
    {
        private ITestManagerService _testManagerService;

        public TestManagerDomain(ITestManagerService testManagerService)
        {
            _testManagerService = testManagerService;
        }

        public TestModel FetchTestData()
        {
            return _testManagerService.TestRepository.FetchData();
        }
    }
}
