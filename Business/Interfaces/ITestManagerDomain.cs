using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ITestManagerDomain
    {
        TestModel FetchTestData();
    }
}
