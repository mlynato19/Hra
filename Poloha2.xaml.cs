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

namespace Hra
{
    /// <summary>
    /// Interakční logika pro Poloha2.xaml
    /// </summary>
    public partial class Poloha2 : Page
    {
        public Poloha2()
        {
            BackdropLib();
        }
        public void BackdropLib()
        {
            background.ImageSource = new BitmapImage(new Uri(@"./photos/interior.jpg", UriKind.Relative));
        }
        public void Dal_Click(object sender, RoutedEventArgs e)
        {

        }

        public void LeftBut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightBut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
