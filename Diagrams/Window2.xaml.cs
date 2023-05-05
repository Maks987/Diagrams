using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Color = System.Drawing.Color;

namespace Diagrams
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void formsPlot2_Loaded(object sender, RoutedEventArgs e)
        {
            Random rand = new(0);
            List<ScottPlot.Plottable.Bar> bars = new();
            for (int i = 0; i < 10; i++)
            {
                int value = rand.Next(25, 100);
                ScottPlot.Plottable.Bar bar = new()
                {
                    Value = value,
                    Position = i,
                    FillColor = Palette.Category10.GetColor(i),
                    Label = value.ToString(),
                };
                bars.Add(bar);
            }
            formsPlot2.Plot.AddBarSeries(bars);
            formsPlot2.Plot.SetAxisLimitsY(0, 120);
            formsPlot2.Refresh();

        }
    }
}
