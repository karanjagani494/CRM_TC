using SoftwareEngineering_2024.DB_connect;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;


namespace SoftwareEngineering_2024.utilities
{
    internal class DataVisualization
    {
        private db_connect db = new db_connect();
        public bool GenerateChart(
    Chart chartControl,
    string sqlQuery,
    SeriesChartType chartType,
    string legendText,
    string xAxisLabel,
    string yAxisLabel
)
        {
            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, db.GetConnection()))
            {
                try
                {
                    db.OpenConnection();

                    // Execute the SQL query
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing data in the chart
                    chartControl.Series.Clear();
                    chartControl.Titles.Clear();

                    // Create a new series
                    Series series = new Series(legendText);
                    series.ChartType = chartType;

                    // Populate the series with data from the query
                    while (reader.Read())
                    {
                        string xValue = reader[0].ToString();       // First column for X-axis (e.g., labels)
                        double yValue = Convert.ToDouble(reader[1]); // Second column for Y-axis (e.g., values)

                        series.Points.AddXY(xValue, yValue);
                    }

                    // Add the series to the chart
                    chartControl.Series.Add(series);

                    // Add chart title (optional)
                    chartControl.Titles.Add("Generated Chart");

                    // Set chart area labels
                    if (chartControl.ChartAreas.Count == 0)
                        chartControl.ChartAreas.Add(new ChartArea());

                    ChartArea chartArea = chartControl.ChartAreas[0];
                    chartArea.AxisX.Title = xAxisLabel;
                    chartArea.AxisY.Title = yAxisLabel;

                    // Add legend
                    if (chartControl.Legends.Count == 0)
                        chartControl.Legends.Add(new Legend());

                    chartControl.Legends[0].Title = legendText;

                    // Close the reader
                    reader.Close();

                    // Success
                    return true;
                }
                catch (Exception ex)
                {
                    // Log the error
                    Console.WriteLine("Error generating chart: " + ex.Message);
                    return false;
                }
                finally
                {
                    // Ensure the connection is closed
                    db.CloseConnection();
                }
            }
        }


    }
}
