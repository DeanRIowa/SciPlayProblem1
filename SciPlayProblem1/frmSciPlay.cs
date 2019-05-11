using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;



namespace SciPlayProblem1
{



    public partial class frmSciPlay : Form
    {
        
        public frmSciPlay()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.Form1_Load); //FIRES!

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SciPlayMaxYearsAlive();
        }
     
     


        public void SciPlayMaxYearsAlive()
        {

            // Set Axis titles
            this.chtMostAliveYears.ChartAreas[0].AxisY.Title = "Occurences";
            this.chtMostAliveYears.ChartAreas[0].AxisX.Title = "Living Years";
         
            // Set Chart series
            Series series = this.chtMostAliveYears.Series[0];
            series.Color = Color.Blue;
            series.LegendText = "People Alive Years";
            this.chtMostAliveYears.Series[0].YValueType = ChartValueType.Int32;

            Series series2 = this.chtMostAliveYears.Series.Add("Most Alive Year(s)");
            series2.Color = Color.Red;
            this.chtMostAliveYears.Series[1].YValueType = ChartValueType.Int32;

            // Set variables
            int[] aliveYears = new int[101];
            int MostAliveCount = 0;

            // Load data
            int[,] people = new int[,]
               {
                                                 { 1910,1926},
                                                 { 1915,1945},
                                                { 1924,1985},
                                                { 1922,1985},
                                                { 1923,1985},
                                                { 1946,1969},
                                                 { 1929,1937},
                                                  { 1941,1945},
                                                { 1956,1985}
                                                };

            // Cycle and calulcate people living per year
            for (int i = 0; i < people.GetLength(0); i++)
            {
                    for (int j = people[i, 0] - 1900; j <= people[i, 1] - 1900; j++)
                {
                    aliveYears[j]++;
                    if (aliveYears[j] >= MostAliveCount)
                    {
                        MostAliveCount = aliveYears[j];
                    }
                };
            };


            // Load chart ID most living year(s)
            string aliveMaxYear = "";
            for (int j = 0; j <= 100; j++)
            {
                if (aliveYears[j] > 0)
                {
                    if (aliveYears[j] == MostAliveCount)
                    {
                        series2.Points.AddXY(j + 1900, aliveYears[j]);
                        if (aliveMaxYear.Length > 0)
                        {
                            aliveMaxYear = aliveMaxYear + ", ";
                        };
                        aliveMaxYear = aliveMaxYear + Convert.ToString(j + 1900);
                    }
                    else
                    {
                        series.Points.AddXY(j + 1900, aliveYears[j]);
                    };
                };
            };


            // Load Most Alive year(s)
            this.lblMostAliveYearsList.Text =  aliveMaxYear;
        }
    }
}
