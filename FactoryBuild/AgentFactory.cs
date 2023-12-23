using Clean.Architecture.CaseUse;
using Clean.Architecture.Domain;

namespace FactoryBuild
{
    public class AgentFactory
    {
        public static IAgent CreateAgent(char agentType)
        {
            switch (agentType)
            {
                case 'A':
                    return new AgentA();
                case 'B':
                    return new AgentB();
                case 'C':
                    return new AgentC();
                default:
                    throw new ArgumentException("Tipo de agente no válido.");
            }
        }
    }
}