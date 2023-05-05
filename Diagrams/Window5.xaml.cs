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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void formsPlot5_Loaded(object sender, RoutedEventArgs e)
        {

            double[] values = { 11, 16, 7, 3, 14 };
            var coxcomb = formsPlot5.Plot.AddCoxcomb(values);
            coxcomb.FillColors = formsPlot5.Plot.Palette.GetColors(5, 0, .5);
            coxcomb.SliceLabels = new string[] { "bikes", "blimps", "subs", "saucers", "rockets" };
            formsPlot5.Plot.Legend();
            formsPlot5.Refresh();
        }
    }
}
