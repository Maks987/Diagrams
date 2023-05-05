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
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void formsPlot7_Loaded(object sender, RoutedEventArgs e)
        {
            double[] values = { 100, 80, 65, 45, 20 };
            formsPlot7.Plot.AddRadialGauge(values);
            formsPlot7.Refresh();
        }
    }
}
