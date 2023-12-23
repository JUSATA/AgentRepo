using Clean.Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.CaseUse
{
    public class AgentUseCase
    {
        private readonly IAgent _Agentcase;

        public AgentUseCase(IAgent Agentcase)
        {
            _Agentcase = Agentcase;
        }

        public MedianResult generateMedianResult(List<int> valores)
        {
            return _Agentcase.getMedia(valores);
        }
        public StairCaseResult generateStairCaseResult(int n)
        {
            return _Agentcase.getStaircase(n);
        }
    }

}
