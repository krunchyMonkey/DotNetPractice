using System;
using System.Collections.Generic;
using System.Text;

namespace TestManager.Interfaces
{
    public interface ITestManagerService
    {
        ITestRepository TestRepository { get; }
    }
}
