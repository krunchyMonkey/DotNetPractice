using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestManager.Interfaces
{
    public interface ITestRepository
    {
        TestModel FetchData();
    }
}
