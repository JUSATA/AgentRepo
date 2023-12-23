using Clean.Architecture.CaseUse;
using Clean.Architecture.Domain;
namespace Clean.Architecture.Presentation
{
    public class AgentController
    {
        private readonly AgentUseCase _agentUseCase;

        public AgentController(AgentUseCase agentUseCase)
        {
            _agentUseCase = agentUseCase;
        }

        public void DisplayAgentFunctions(List<int> valores, int n)
        {
            MedianResult resultMedia = _agentUseCase.generateMedianResult(valores);
            StairCaseResult resultStairCase = _agentUseCase.generateStairCaseResult(n);
            Console.WriteLine("Operaciones Agente");

            Console.WriteLine(" Media result:" + resultMedia.medianResult );
            Console.WriteLine(" Stair case result " + resultStairCase.stairCaseResult );
        }
    }
}