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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void formsPlot3_Loaded(object sender, RoutedEventArgs e)
        {
            double[] values = { 778, 43, 283, 76, 184 };
            var pie = formsPlot3.Plot.AddPie(values);
            pie.ShowPercentages = true;
            formsPlot3.Refresh();

            //double[] values = { 778, 43, 283, 76, 184 };
            //var pie = plt.AddPie(values);
            //pie.ShowValues = true;
            //pie.SliceLabelPosition = 0.6;
            //pie.Size = .7;
            //pie.SliceLabelColors = pie.SliceFillColors;
        }
    }
}
