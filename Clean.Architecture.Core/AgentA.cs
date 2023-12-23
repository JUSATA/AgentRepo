using System.Text;
using Clean.Architecture.Domain;


namespace Clean.Architecture.Domain
{
    public class AgentA : IAgent
    {
        public MedianResult getMedia(List<int> valores)
        {
            if (valores == null || valores.Count == 0)
            {
                throw new ArgumentException("La lista de números no puede estar vacía");
            }

            double sum = valores.Sum();
            double mean = sum / valores.Count;

            return  new MedianResult { medianResult = mean };
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