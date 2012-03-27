using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReportGenerator
{
    public class PrettyChart : Chart
    {
        public PrettyChart()
        {
            var title1 = new Title {Name = "Title1", Text = "<TITLE>"};
            Titles.Add(title1);

            var area = new ChartArea();
            area.AxisY.LabelStyle.Enabled = true;
            area.AxisY.Interval = 1.0;
            area.AxisX.LabelStyle.Enabled = true;
            area.Name = "ChartArea2";

            var legend1 = new Legend {Alignment = StringAlignment.Center, Docking = Docking.Top, Name = "Legend1"};
            Legends.Add(legend1);

            var series2 = new Series
                              {
                                  ChartArea = "ChartArea2",
                                  Color = Color.Blue,
                                  Legend = "Legend1",
                                  Name = "Series2",
                                  XValueType = ChartValueType.Int32
                              };

            ChartAreas.Add(area);
            Series.Add(series2);
            Dock = DockStyle.Fill;
            Location = new Point(0, 0);

            Titles[0].Text = "Age Distribution";
            Series[0].Name = "Number of People";
        }

        public void WriteToDisk(string fileName, double numUnder30, double num30To40, double numOver40)
        {
            var points = Series[0].Points;
            points.Add(new DataPoint(30.0, numUnder30));
            points.Add(new DataPoint(35.0, num30To40));
            points.Add(new DataPoint(40.0, numOver40));

            SaveImage(fileName, ChartImageFormat.Png);
        }
    }
}