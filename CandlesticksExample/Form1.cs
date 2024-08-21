

using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace CandlesticksExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*var plotModel = new PlotModel { Title = "Candlestick Chart" };

            var candleStickSeries = new CandleStickSeries
            {
                Color = OxyColors.Black,
                IncreasingFill = OxyColors.Green,
                DecreasingFill = OxyColors.Red,
            };

            // Example data
            candleStickSeries.Items.Add(new HighLowItem(DateTimeAxis.ToDouble(new DateTime(2024, 8, 20)), 200, 180, 195, 190));
            candleStickSeries.Items.Add(new HighLowItem(DateTimeAxis.ToDouble(new DateTime(2024, 8, 21)), 205, 185, 200, 190));

            plotModel.Series.Add(candleStickSeries);

            var plotView = new PlotView
            {
                Model = plotModel,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(plotView);*/

            var plotModel = new PlotModel { Title = "Candlestick Chart" };

            // Set up the DateTimeAxis for the X-axis
            var dateTimeAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,      // Set position of the X-axis
                StringFormat = "yyyy-MM-dd",         // Date format
                Title = "Date",                      // Title of the X-axis
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                IntervalType = DateTimeIntervalType.Days,  // Adjust interval as needed
                MajorStep = 1                        // Major step for gridlines
            };

            plotModel.Axes.Add(dateTimeAxis);

            // Set up the Y-axis (if needed)
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left,        // Set position of the Y-axis
                Title = "Price",                     // Title of the Y-axis
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            };

            plotModel.Axes.Add(valueAxis);

            var candleStickSeries = new CandleStickSeries
            {
                Color = OxyColors.Black,
                IncreasingFill = OxyColors.Green,
                DecreasingFill = OxyColors.Red,
            };

            // Example data
            candleStickSeries.Items.Add(new HighLowItem(DateTimeAxis.ToDouble(new DateTime(2024, 8, 20)), 200, 180, 195, 190));
            candleStickSeries.Items.Add(new HighLowItem(DateTimeAxis.ToDouble(new DateTime(2024, 8, 21)), 205, 185, 200, 390));

            plotModel.Series.Add(candleStickSeries);

            var plotView = new PlotView
            {
                Model = plotModel,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(plotView);
        }
        public class Candlestick
        {
            public DateTime Time { get; set; }
            public decimal Open { get; set; }
            public decimal Close { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }

            public Candlestick(DateTime time, decimal open, decimal close, decimal high, decimal low)
            {
                Time = time;
                Open = open;
                Close = close;
                High = high;
                Low = low;
            }
        }
    }
}
