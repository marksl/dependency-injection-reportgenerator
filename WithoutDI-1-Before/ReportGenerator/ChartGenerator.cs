using System.Collections.Generic;
using DatabaseConnector;

namespace ReportGenerator
{
    public class ChartGenerator
    {
        public void CreateChart(string fileName)
        {
            var chart = new PrettyChart();

            var databaseConnector = new InMemoryDatabase();

            List<User> users = databaseConnector.GetUsers();

            int numberOfUsersUnder30 = 0;
            int numberOfUsers30To40 = 0;
            int numberOfUsersOver40 = 0;

            foreach (User user in users)
            {
                if (user.Age < 30)
                {
                    numberOfUsersUnder30 += 1;
                }
                else if (user.Age > 40)
                {
                    numberOfUsersOver40 += 1;
                }
                else
                {
                    numberOfUsers30To40 += 1;
                }
            }

            chart.WriteToDisk(fileName, numberOfUsersUnder30, numberOfUsers30To40, numberOfUsersOver40);
        }
    }
}