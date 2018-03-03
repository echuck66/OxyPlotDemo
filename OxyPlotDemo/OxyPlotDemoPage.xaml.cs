using OxyPlot.Xamarin.Forms;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace OxyPlotDemo
{
    public partial class OxyPlotDemoPage : ContentPage
    {
        public OxyPlotDemoPage()
        {
            InitializeComponent();
            PlotView pv = new PlotView();
            pv.VerticalOptions = LayoutOptions.Fill;
            pv.HorizontalOptions = LayoutOptions.Fill;

            List<DataPoint> points = new List<DataPoint>();

            // LineSeries Plots:
            // Define the data for the plot. 
            // e.g. var y = Math.Pow(x, 2),
            //      var y = Math.Cos(x),
            //      var y = Math.Sin(x), etc.
            // 
            for (double x = -10; x <= 10; x = x + .1)
            {
                var y = Math.Pow(x, x);
                points.Add(new DataPoint(x,y));
            }
            string title = "f(x) = x^x";
            var model = new PlotModel { Title = title };
            var lineSeries = new LineSeries { MarkerType = MarkerType.Cross };
            lineSeries.Points.AddRange(points);
            model.Series.Add(lineSeries);

            // ScatterSeries plots:
            //var model = new PlotModel { Title = "ScatterSeries" };
            //var scatterSeries = new ScatterSeries { MarkerType = MarkerType.Circle };
            //var r = new Random(314);
            //for (int i = 0; i < 100; i++)
            //{
            //    var x = r.NextDouble();
            //    var y = r.NextDouble();
            //    var size = r.Next(5, 15);
            //    var colorValue = r.Next(100, 1000);
            //    scatterSeries.Points.Add(new ScatterPoint(x, y, size, colorValue));
            //}
            //model.Series.Add(scatterSeries);
            //model.Axes.Add(new LinearColorAxis { Position = AxisPosition.Right, Palette = OxyPalettes.Jet(200) });

            pv.Model = model;

            this.Content = pv;

        }
    }
}
