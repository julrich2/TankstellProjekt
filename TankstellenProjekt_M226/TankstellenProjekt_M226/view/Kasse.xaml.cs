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

namespace TankstellenProjekt_M226.view
{
    /// <summary>
    /// Interaction logic for Kasse.xaml
    /// </summary>
    public partial class Kasse : Window
    {
        public Kasse()
        {
            InitializeComponent();
        }

        void AddMoney(double Money)
        {
            double paid;
            string result="0";
            paid=Convert.ToDouble(Bezahlt.Content); 
            paid=paid+Money;
            paid = Math.Round(paid, 2);
            
            Bezahlt.Content = Convert.ToString(paid) ;
            
        }

        private void Btn100_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(100);
        }

        private void Btn50_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(50);
        }
        private void Btn20_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(20);
        }

        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(10);
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(5);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(2);
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(1);
        }

        private void Btn05_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(0.50);
        }

        private void Btn02_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(0.20);
        }

        private void Btn01_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(0.10);
        }

        private void Btn005_Click(object sender, RoutedEventArgs e)
        {
            AddMoney(0.05);
        }
    }
}
