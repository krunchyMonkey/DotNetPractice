using System;
using System.Collections.Generic;
using System.Text;
using TestManager.Interfaces;

namespace TestManager
{
    public class TestManagerService : ITestManagerService
    {
        private Lazy<ITestRepository> _testRepository;
        public ITestRepository TestRepository => _testRepository.Value;

        public TestManagerService(Lazy<ITestRepository> testRepository)
        {
            _testRepository = testRepository;
        }
    }
}
