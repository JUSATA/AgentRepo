using System.Text;

namespace Clean.Architecture.Domain
{
    public class AgentC : IAgent
    {
        public MedianResult getMedia(List<int> valores)
        {
            if (valores == null || valores.Count == 0)
            {
                throw new ArgumentException("La lista de números no puede estar vacía");
            }
            List<int> sortedNumbers = valores.OrderBy(num => num).ToList();
            int count = sortedNumbers.Count;

            if (count % 2 == 0)
            {
                // Cantidad de datos es par
                int middleIndex1 = count / 2 - 1;
                int middleIndex2 = count / 2;
                double median = (sortedNumbers[middleIndex1] + sortedNumbers[middleIndex2]) / 2;
                return new MedianResult { medianResult = median };
            }
            else
            {
                // Cantidad de datos es impar
                int middleIndex = count / 2;
                double median = sortedNumbers[middleIndex];
                return new MedianResult { medianResult = median };
            }
        }

        public StairCaseResult getStaircase(int valores)
        {
            if (valores <= 0 || valores >= 100)
            {
                throw new ArgumentException("El tamaño de la escalera debe estar entre 0 y 100.");
            }

            StringBuilder staircaseBuilder = new StringBuilder();

            for (int i = 0; i < valores; i++)
            {
                
                int leadingSpaces = Math.Abs((valores - 1) / 2 - i);

               
                staircaseBuilder.Append(new string(' ', leadingSpaces));

               
                staircaseBuilder.Append(new string('#', valores - 2 * leadingSpaces));

                
                if (i < valores - 1)
                {
                    staircaseBuilder.AppendLine();
                }
            }
            return new StairCaseResult { stairCaseResult = staircaseBuilder.ToString() };
        }
    }

}