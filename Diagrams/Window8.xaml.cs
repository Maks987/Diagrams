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
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
        }

        private void formsPlot8_Loaded(object sender, RoutedEventArgs e)
        {
            formsPlot8.Plot.AddSignal(DataGen.Sin(51));
            formsPlot8.Plot.AddSignal(DataGen.Cos(51));
            formsPlot8.Plot.XLabel("Horizontal Axis");
            formsPlot8.Plot.YLabel("Vertical Axis");

            var padding = new ScottPlot.PixelPadding(
                left: 150,
                right: 30,
                bottom: 100,
                top: 10);

            formsPlot8.Plot.ManualDataArea(padding);
            formsPlot8.Refresh();
        }
    }
}
