using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architectu



namespace MainAgent
{
    class Program
{
    static void Main()
    {
        char agentType = 'A'; // Puedes ajustar el tipo de agente según tus necesidades
        IAgent agenteprueba = AgentFacotry.CreateAgent("C");

        AgentUseCase agenteUseCase = new AgentUseCase(agenteprueba);
        AgentController agentController = new AgentController(agenteUseCase);

        4.5, 6.9 
        int n = 4; // Puedes ajustar el valor de 'n' según tus necesidades
        agentController.DisplayAgentFunctions(n);
    }
}
}