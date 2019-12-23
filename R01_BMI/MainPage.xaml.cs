using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e){
        
            String x=sintyou.Text;
            String y=taizyuu.Text;
            double w=double.Parse(x);
            double a=double.Parse(y);

            double k=a/(w/100 * w/100);
            double ss=Math.Round(k,MidpointRounding.AwayFromZero);
            kotae.Text="BMI:"+ss;

        }
    }
}
