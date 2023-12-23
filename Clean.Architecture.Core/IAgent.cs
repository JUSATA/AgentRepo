using Clean.Architecture.Domain;
namespace Clean.Architecture.Domain

{
    public interface IAgent
    {
        public MedianResult getMedia(List<int> valores);
        public StairCaseResult getStaircase(int valores);
    }
}