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

namespace Diagrams
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void formsPlot6_Loaded(object sender, RoutedEventArgs e)
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
                    FillColor = ScottPlot.Palette.Category10.GetColor(i),
                    Label = value.ToString(),
                    IsVertical = false, 
                };
                bars.Add(bar);
            };

            formsPlot6.Plot.AddBarSeries(bars);
            formsPlot6.Plot.SetAxisLimitsX(0, 120);
            formsPlot6.Refresh();
        }
    }
}
