
using Clean.Architecture.Domain;
using System.Text;

namespace Clean.Architecture.Domain
{
    public class AgentB : IAgent
    {
        public MedianResult getMedia(List<int> valores)
        {
            if (valores == null || valores.Count == 0)
            {
                throw new ArgumentException("La lista de números no puede estar vacía");
            }

            double reciprocalSum = valores.Sum(num => 1 / num);
            double harmonicMean = valores.Count / reciprocalSum;

            return new MedianResult { medianResult = harmonicMean };
        }

        public StairCaseResult getStaircase(int valores)
        {
            if (valores <= 0 || valores >= 100)
            {
                throw new ArgumentException("El tamaño de la escalera debe estar entre 0 y 100.");
            }

            StringBuilder staircaseBuilder = new StringBuilder();

            for (int i = 1; i <= valores; i++)
            {
                
                staircaseBuilder.Append(new string(' ', valores - i));

                
                staircaseBuilder.Append(new string('#', i));

                
                if (i < valores)
                {
                    staircaseBuilder.AppendLine();
                }
            }

            return new StairCaseResult { stairCaseResult = staircaseBuilder.ToString() };

        }
    }

}