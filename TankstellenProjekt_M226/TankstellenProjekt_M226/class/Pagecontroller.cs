using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _00_trainingApp.Controller
{
    public class Pagecontroller
    {
        public static void NextWindow(Window startwindow, Window targetwindow)
        {
            targetwindow.Show();
            startwindow.Close();

        }
    }
}
