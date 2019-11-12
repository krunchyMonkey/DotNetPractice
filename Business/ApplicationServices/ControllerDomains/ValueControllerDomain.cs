using Business.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ApplicationServices.ControllerDomains
{
    public class ValueControllerDomain : IValueControllerDomain
    {
        private readonly ITestManagerDomain _testManagerDomain;
        public ValueControllerDomain(ITestManagerDomain testManagerDomain)
        {
            _testManagerDomain = testManagerDomain;
        }

        public TestModel FetchData()
        {
            return _testManagerDomain.FetchTestData();
        }
    }
}
