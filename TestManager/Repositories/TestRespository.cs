using Model;
using System;
using System.Collections.Generic;
using System.Text;
using TestManager.Interfaces;

namespace TestManager.Repositories
{
    public class TestRespository : ITestRepository
    {
        public TestRespository() {
        }

        public TestModel FetchData()
        {
            var model = new TestModel()
            {
                TestProperty = "Hello Repo~!"
            };

            return model;
        }
    }
}
