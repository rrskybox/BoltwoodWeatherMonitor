using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitor
{
    public partial class FormWeatherMonitor : Form
    {

        private bool openFlag = false;

        //Wind databank
        private double windNow = 0;
        private double maxWind = 0;
        private double avgWind = 0;
        private Queue<double> wFIFO = new Queue<double>(60);
        //Cloud databank
        private int cloudNow = 0;
        private int maxCloud = 0;
        private int avgCloud = 0;
        private Queue<int> cFIFO = new Queue<int>(60);
        //Rain databank
        private int rainNow = 0;
        private int maxRain = 0;
        private int avgRain = 0;
        private Queue<int> rFIFO = new Queue<int>(60);

        public FormWeatherMonitor()
        {
            InitializeComponent();
            this.Show();
            openFlag = true;

            //WeatherReport.Text = "Monitoring CloudWatcher";
            SinceDateTimeBox.Text = DateTime.Now.ToString("MM/dd HH:mm");
            this.Show();
            System.Windows.Forms.Application.DoEvents();

            while (openFlag)
            {
                //Get data from weather file
                UpdateWeatherData();
                //Update wind data
                WindNowTextBox.Text = windNow.ToString("0.0") + " mph";
                WindMaxTextBox.Text = maxWind.ToString("0.0") + " mph";
                WindAvgTextBox.Text = avgWind.ToString("0.0") + " mph";
                //Update cloud data
                CloudNowTextBox.Text = ConvertCloud(cloudNow);
                CloudMaxTextBox.Text = ConvertCloud(maxCloud);
                CloudAvgTextBox.Text = ConvertCloud(avgCloud);
                //Update rain data
                RainNowTextBox.Text = ConvertRain(rainNow) ;
                RainMaxTextBox.Text = ConvertRain(maxRain) ;
                RainAvgTextBox.Text = ConvertRain(avgRain);
                //Show and Wait
                Show();
                Application.DoEvents();
                for (int i = 0; i < 10; i++) //10 second wait loop, but keep popping up for events
                {
                    System.Threading.Thread.Sleep(1000);
                    Show();
                    Application.DoEvents();
                    if (!openFlag) break;
                }
            }
            Close();
            return;
        }

        private void UpdateWeatherData()
        {
            //Poll the weather file readings, create averages and check for max
            WeatherFileReader wmon = new WeatherFileReader();
            //Wind
            windNow = wmon.WindSpeed;
            if (windNow > maxWind) maxWind = windNow;
            wFIFO.Enqueue(windNow);
            avgWind = wFIFO.Average();
            //Rain
            rainNow = Convert.ToInt16(wmon.Raininess);
            if (rainNow > maxRain) maxRain = rainNow;
            rFIFO.Enqueue(rainNow);
            avgRain = (int)rFIFO.Average();
            //Cloud
            cloudNow = Convert.ToInt16(wmon.Cloudiness);
            if (cloudNow > maxCloud) maxCloud = cloudNow;
            cFIFO.Enqueue(cloudNow);
            avgCloud = (int)cFIFO.Average();
            wmon = null;
            return;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            openFlag = false;
        }

   private string ConvertCloud (int cloudiness)
        {
            //Converts cloudiness value to string
            if (cloudiness == 1) return "Clear";
            if (cloudiness == 2) return "Cloudy";
            if (cloudiness == 3) return "Overcast";
            return "?";
        }
        private string ConvertRain(int raininess)
        {
            //Converts raininess value to string
            if (raininess == 1) return "Dry";
            if (raininess == 2) return "Damp";
            if (raininess == 3) return "Raining";
            return "?";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Reset the max wind, rain, cloud to zero and clear the FIFOs
            maxWind = 0;
            maxRain = 0;
            maxCloud = 0;
            wFIFO.Clear();
            cFIFO.Clear();
            rFIFO.Clear();
            SinceDateTimeBox.Text = DateTime.Now.ToString("MM/dd HH:mm");
            return;
        }

 
    }
}

