using OxyPlot;
using OxyPlot.Xamarin.Forms;
using Xamarin.Forms;

namespace OxyPlotDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            this.MainPage = new OxyPlotDemoPage
            {
                //Content = new PlotView
                //{
                //    Model = new PlotModel { Title = "Hello, Forms!" },
                //    VerticalOptions = LayoutOptions.Fill,
                //    HorizontalOptions = LayoutOptions.Fill,
                //},
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
