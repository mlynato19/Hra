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
    /// Interakční logika pro Venek.xaml
    /// </summary>
    /// 
    public partial class Venek : Page
    {
        public int kleft = -700;
        public int ktop = -100;

        public Venek()
        {
            InitializeComponent();

        }

        private void TheGrid_OnLoaded(object sender, RoutedEventArgs e)
        {
            theGrid.Focus();
        }

        private void Press(object sender, KeyEventArgs e)
        {
            Cont.Content = kleft;
            Cont2.Content = ktop;

            if (kleft <= -750)
            {
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
            }
            else if (e.Key == Key.Left)
            {
                kleft -= 10;
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
            }

            if (kleft >= 700)
            {
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
                
            }
            else if (e.Key == Key.Up)
            {
                ktop -= 10;
                rac.Margin = new Thickness(kleft, ktop, 0, 0);

            }

            if (ktop >= 300)
            {
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
            }
            else if (e.Key == Key.Down)
            {
                ktop += 10;
                rac.Margin = new Thickness(kleft, ktop, 0, 0);

            }

            if (ktop <= -330)
            {
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
                //MessageBox.Show("a");
            }
            else if (e.Key == Key.Right)
            {
                kleft += 10;
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
            }

            
        }

        
    }
}
