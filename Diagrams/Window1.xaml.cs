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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void formsPlot1_Loaded(object sender, RoutedEventArgs e)
        {
            double[] values = { 778, 43, 283, 76, 184 };
            string[] SliceLabels = { "Cat", "Dog", "Snake", "Frog", "Fox" };
            string[] LegendLabels = { "Meow", "Woof", "Ssst", "Ribbit", "RingDing" };

            var pie = formsPlot1.Plot.AddPie(values);
            pie.SliceLabels = SliceLabels;
            pie.ShowLabels = true;

            pie.LegendLabels = LegendLabels;
            formsPlot1.Plot.Legend();
            formsPlot1.Refresh();
        }
    }
}
