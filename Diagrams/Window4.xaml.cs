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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void formsPlot4_Loaded(object sender, RoutedEventArgs e)
        {
            double[] values = { 778, 283, 184, 76, 43 };
            var pie = formsPlot4.Plot.AddPie(values);
            pie.Explode = true;
            pie.DonutSize = .6;
            formsPlot4.Refresh();
        }
    }
}
