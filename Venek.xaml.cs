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
        public int kleft = 0;
        public int ktop = 0;
        public bool done = Var.Byl;


        public Venek(string odkud)
        {
            InitializeComponent();

            uzbyl.Visibility = Visibility.Collapsed;

            if (odkud == "vnitrek")
            {
                rac.Margin = new Thickness(-660, -90, 0, 0);
                kleft = -660;
                ktop = -90;
            }
            else if (odkud == "zahrada")
            {
                rac.Margin = new Thickness(-410, -90, 0, 0);
                kleft = -410;
                ktop = -90;
            }
            else if (odkud == "hospoda")
            {
                rac.Margin = new Thickness(580, 10, 0, 0);
                kleft = 580;
                ktop = -10;
            }
            else if (odkud == "marie")
            {
                rac.Margin = new Thickness(-410, 100, 0, 0);
                kleft = -410;
                ktop = 100;
            }
            else if (odkud == "viktorie")
            {
                rac.Margin = new Thickness(-150, -90, 0, 0);
                kleft = -150;
                ktop = -90;
            }
            else if (odkud == "vojtech")
            {
                rac.Margin = new Thickness(130, -90, 0, 0);
                kleft = 130;
                ktop = -90;
            }
            else if (odkud == "detektivna")
            {
                rac.Margin = new Thickness(-70, 100, 0, 0);
                kleft = -70;
                ktop = 100;
            }
            else if (odkud == "dum")
            {
                rac.Margin = new Thickness(-660, 100, 0, 0);
                kleft = -660;
                ktop = 100;
                done = true;
            }

            if (done== true)
            {
                uzbyl.Visibility = Visibility.Visible;
            }

        }

        private void TheGrid_OnLoaded(object sender, RoutedEventArgs e)
        {
            theGrid.Focus();
        }

        private void Press(object sender, KeyEventArgs e)
        {
            //Cont.Content = kleft;
            //Cont2.Content = ktop;

            if (kleft <= -750)
            {
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
            }
            else if (e.Key == Key.Left)
            {
                kleft -= 10;
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
            }

            if (ktop <= -330)
            {
                rac.Margin = new Thickness(kleft, ktop, 0, 0);

            }
            else if (e.Key == Key.Up)
            {
                ktop -= 10;
                rac.Margin = new Thickness(kleft, ktop, 0, 0);

            }

            if (ktop >= 330)
            {
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
            }
            else if (e.Key == Key.Down)
            {
                ktop += 10;
                rac.Margin = new Thickness(kleft, ktop, 0, 0);

            }

            if (kleft >= 730)
            {
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
                //MessageBox.Show("a");
            }
            else if (e.Key == Key.Right)
            {
                kleft += 10;
                rac.Margin = new Thickness(kleft, ktop, 0, 0);
            }






            if (ktop <= -180 && kleft >= -720 && kleft <= -610)
            {
                NavigationService.Navigate(new Poloha2("vnitrek"));
                //NavigationService next = NavigationService.GetNavigationService(this);
                //next.Navigate(new Uri("Poloha2.xaml", UriKind.Relative));
            }

            if (ktop <= -180 && kleft >= -460 && kleft <= -350)
            {
                NavigationService.Navigate(new Poloha2("zahrada"));
            }

            if (ktop <= -180 && kleft >= -180 && kleft <= -90)
            {
                NavigationService.Navigate(new Poloha2("viktorie"));
            }

            if (ktop <= -180 && kleft >= 70 && kleft <= 170)
            {
                NavigationService.Navigate(new Poloha2("vojtech"));
            }


            if (ktop <= -80 && kleft >= 410 && kleft <= 720)
            {

                NavigationService.Navigate(new Poloha2("hospoda"));
            }

            if (ktop >= 110 && kleft >= -170 && kleft <= 70)
            {
                NavigationService.Navigate(new Poloha2("detektivna"));
            }

            if (ktop >= 110 && kleft >= -520 && kleft <= -350)
            {
                NavigationService.Navigate(new Poloha2("marie"));
            }

            if (ktop >= 110 && kleft >= -720 && kleft <= -610)
            {
                if (done == true)
                {
                    uzbyl.Visibility = Visibility.Visible;
                } else
                {
                    NavigationService next = NavigationService.GetNavigationService(this);
                    next.Navigate(new Uri("Hledacka.xaml", UriKind.Relative));
                }
                
            }
        }

        
    }
}
