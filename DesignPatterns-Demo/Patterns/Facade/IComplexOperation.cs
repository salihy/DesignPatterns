using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Facade
{
    public interface IComplexOperation
    {
        //Task<string> GetNameOfOperationByExecutionPlanName(string executionPlanName, int recurringId, bool x, List<int> asas);
        //Task<string> GetExecutionTimeout(string executionPlanName, int recurringId);
        //Task<string> GetOperationX(string asas, int absas, bool x, List<int> gb4);

        Task<string> getOpName(string executionPlanName);


    }
}
