using CarRentalAutomation.Class;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalAutomation
{
    public partial class SplashScreen : BaseForm
    {

        public SplashScreen()
        {
            InitializeComponent();

            this.Opacity = 0; 
            lblStatus.Text = "Yükleniyor...";
            progressBar1.Value = 0;
            progressBar1.ForeColor = Color.FromArgb(0, 0, 0);
            this.ShowInTaskbar = false;

        }


        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            timerFadeIn.Start();  
            await ReadDB();
            await Task.Delay(500); 

            timerFadeOut.Start();

            
        }

        private async Task ReadDB()
        {

            Data.GetBrandData();

            lblStatus.Text = "Markalar yükleniyor... %25";
            progressBar1.Value = 25;
            await Task.Delay(1000);

            Data.GetModelData();

            lblStatus.Text = "Modeller yükleniyor... %50";
            progressBar1.Value = 50;
            await Task.Delay(1000);

            Data.GetColorData();

            lblStatus.Text = "Renkler yükleniyor... %75";
            progressBar1.Value = 75;
            await Task.Delay(1000);

            Data.GetCustomersData();
            Data.GetCarsData();
            Data.GetStaffsData();
    

            lblStatus.Text = "Kullanıcı dataları yükleniyor... %100";
            progressBar1.Value = 100;
            await Task.Delay(1000);
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timerFadeIn.Stop();
            }
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                timerFadeOut.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
