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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diagrams
{
    public partial class MainWindow : Window
    {
        public static Window1? CircleWindow;
        public static Window2? BarsWindow;
        public static Window3? LabelEverythingWindow;
        public static Window4? DonutChartWindow;
        public static Window5? RadialGaugeWindow;
        public static Window6? BarSeriesHorizontalWindow;
        public static Window7? CoxcombChartWindow;
        public static Window8? ManualDataAreaWindow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CircleDiagram_Click(object sender, RoutedEventArgs e)
        {
            if (CircleWindow == null)
            {
                CircleWindow = new Window1();
                CircleWindow.Show();
            }
            else CircleWindow.Activate();
        }

        private void BarsDiagram_Click(object sender, RoutedEventArgs e)
        {
            if (BarsWindow == null)
            {
                BarsWindow = new Window2();
                BarsWindow.Show();
            }
            else BarsWindow.Activate();
        }

        private void LabelEverythingDiagram_Click(object sender, RoutedEventArgs e)
        {
            if (LabelEverythingWindow == null)
            {
                LabelEverythingWindow = new Window3();
                LabelEverythingWindow.Show();
            }
            else LabelEverythingWindow.Activate();
        }

        private void DonutChartDiagram_Click(object sender, RoutedEventArgs e)
        {
            if (DonutChartWindow == null)
            {
                DonutChartWindow = new Window4();
                DonutChartWindow.Show();
            }
            else DonutChartWindow.Activate();
        }

        private void RadialGaugeDiagram_Click(object sender, RoutedEventArgs e)
        {
            if (RadialGaugeWindow == null)
            {
                RadialGaugeWindow = new Window5();
                RadialGaugeWindow.Show();
            }
            else RadialGaugeWindow.Activate();
        }

        private void BarSeriesHorizontalDiagram_Click(object sender, RoutedEventArgs e)
        {
            if (BarSeriesHorizontalWindow == null)
            {
                BarSeriesHorizontalWindow = new Window6();
                BarSeriesHorizontalWindow.Show();
            }
            else BarSeriesHorizontalWindow.Activate();
        }

        private void CoxcombChartDiagram_Click(object sender, RoutedEventArgs e)
        {
            if (CoxcombChartWindow == null)
            {
                CoxcombChartWindow = new Window7();
                CoxcombChartWindow.Show();
            }
            else CoxcombChartWindow.Activate();
        }

        private void ManualDataAreaDiagram_Click(object sender, RoutedEventArgs e)
        {
            if (ManualDataAreaWindow == null)
            {
                ManualDataAreaWindow = new Window8();
                ManualDataAreaWindow.Show();
            }
            else ManualDataAreaWindow.Activate();
        }
    }
}
