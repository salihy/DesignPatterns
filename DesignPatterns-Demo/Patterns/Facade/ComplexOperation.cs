using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Facade
{
    public class ComplexOperation : IComplexOperation
    {
        public async Task<string> getOpName(string executionPlanName)
        {
            return await GetNameOfOperationByExecutionPlanName(executionPlanName, 1, true, null);
        }

        private Task<string> GetExecutionTimeout(string executionPlanName, int recurringId)
        {
            throw new NotImplementedException();
        }

        private Task<string> GetNameOfOperationByExecutionPlanName(string executionPlanName, int recurringId, bool x, List<int> asas)
        {
            throw new NotImplementedException();
        }

        private Task<string> GetOperationX(string asas, int absas, bool x, List<int> gb4)
        {
            throw new NotImplementedException();
        }
    }
}
