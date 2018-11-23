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
using System.Windows.Threading;

namespace TankstellenProjekt_M226.view
{
    /// <summary>
    /// Interaction logic for Tanken.xaml
    /// </summary>
    public partial class Tanken : Window
    {
        public Tanken()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromMilliseconds(0.5);
            dt.Tick += dtTicker;
            dt.Start();
        }

        private double increment = 0;
        private void dtTicker(object sender, EventArgs e)
        {
            increment= increment+0.01;
            increment = Math.Round(increment, 2);
            Timerlabel.Content = increment.ToString();
        }
    }
}
