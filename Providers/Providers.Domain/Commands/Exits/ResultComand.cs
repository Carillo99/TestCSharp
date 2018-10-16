namespace Providers.Domain.Commands.Exits
{
    public class ResultComand
    {
        public ResultComand(object Data, int Count)
        {
            this.Data = Data;
            this.Count = Count;
        }

        public object Data { get; set; }
        public int Count { get; set; }
    }
}
