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
            AddMoney(0);
        }

        void AddMoney(double Money)
        {
            string result="0";
            double paid=Convert.ToDouble(Bezahlt.Content);
            double cost = Convert.ToDouble(Kosten.Content);
            double missing = Convert.ToDouble(OBetrag.Content);
            paid =paid+Money;
            paid = Math.Round(paid, 2);
            Bezahlt.Content = Convert.ToString(paid) ;
            missing = cost - paid;
            OBetrag.Content = Convert.ToString(missing);
            if (Convert.ToDouble(missing) < 0)
            {
                missing = Math.Round(missing, 2);
                Rückgeld(missing);
            }
        }
            
        void Rückgeld(double missing)
        {
            int amountof100 =0;
            int amountof50 = 0;
            int amountof20 = 0;
            int amountof10 = 0;
            int amountof5 = 0;
            int amountof2 = 0;
            int amountof1 = 0;
            int amountof05 = 0;
            int amountof02 = 0;
            int amountof01 = 0;
            int amountof005 = 0;
            missing =missing * (-1);
            do
            {
                if (missing>100)
                {
                    missing=missing - 100;
                    amountof100 =+1;
                }
                else
                {
                    if (missing>50)
                    {
                        missing = missing - 50;
                        amountof50 = +1;
                    }
                    else
                    {
                        if (missing > 20)
                        {
                            missing = missing - 20;
                            amountof20 = +1;
                        }
                        else
                        {
                            if (missing > 10)
                            {
                                missing = missing - 10;
                                amountof10 = +1;
                            }
                            else
                            {
                                if (missing > 5)
                                {
                                    missing = missing - 5;
                                    amountof5 = +1;
                                }
                                else
                                {
                                    if (missing >2)
                                    {
                                        missing = missing - 2;
                                        amountof2 = +1;
                                    }
                                    else
                                    {
                                        if (missing > 1)
                                        {
                                            missing = missing - 1;
                                            amountof1 = +1;
                                        }
                                        else
                                        {

                                            if (missing > 0.5)
                                            {
                                                missing = missing - 0.5;
                                                amountof05 = +1;
                                            }
                                            else
                                            {
                                                if (missing > 0.2)
                                                {
                                                    missing = missing - 0.2;
                                                    amountof02 = +1;
                                                }
                                                else
                                                {
                                                    if (missing > 0.1)
                                                    {
                                                        missing = missing - 0.1;
                                                        amountof01 = +1;
                                                    }
                                                    else
                                                    {
                                                        if (missing > 0.05)
                                                        {
                                                            missing = missing - 0.05;
                                                            amountof005 = +1;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            while (missing >= 0);
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
