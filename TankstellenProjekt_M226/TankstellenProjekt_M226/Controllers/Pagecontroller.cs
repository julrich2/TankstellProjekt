using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TankstellenProjekt_M226.Controllers
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
