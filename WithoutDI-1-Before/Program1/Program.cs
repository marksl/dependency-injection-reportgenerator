using ReportGenerator;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];

            var generator = new ChartGenerator();
            generator.CreateChart(fileName);
        }
    }
}
