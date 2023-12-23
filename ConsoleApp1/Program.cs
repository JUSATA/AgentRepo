using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Domain;
using Clean.Architecture.CaseUse;
using Clean.Architecture.Presentation;
using FactoryBuild;

namespace MainAgent
{
    class Program
    {
        static void Main()
        {
            char agentType = 'A';
            IAgent agenteprueba = AgentFactory.CreateAgent(agentType);

            AgentUseCase agenteUseCase = new AgentUseCase(agenteprueba);
            AgentController agentController = new AgentController(agenteUseCase);

            //var miLista = new List<int>();
            //miLista.AddRange(new[] { 1, 2, 3, 4, 5 });


            //var miLista = new List<int>();
            //miLista.AddRange(new[] { 5, 22, 23, 34, 15 });

            var miLista = new List<int>();
            miLista.AddRange(new[] { 8, 32, 2, 3, 15 });

            int n = 9;
            agentController.DisplayAgentFunctions(miLista,n);
        }
    }
}