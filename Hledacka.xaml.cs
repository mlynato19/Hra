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
    /// Interakční logika pro hledacka.xaml
    /// </summary>
    public partial class Hledacka : Page
    {
        public int i = 0;
        public Hledacka()
        {
            InitializeComponent();
            jmenovka.Text = "Detektiv";
            textbox.Text = "Tento dům je něčím divný... Dveře byly otevřené a dům se zdá být opuštěný, ale něco tu nehraje, skoro jako kdyby ho vrah používal jako skrýš. Měl bych ho prohledat.";
            find.Visibility = Visibility.Collapsed;
            nuz.Visibility = Visibility.Collapsed;
            pantofle.Visibility = Visibility.Collapsed;
            lahev.Visibility = Visibility.Collapsed;
            nemcina.Visibility = Visibility.Collapsed;
            ponozka.Visibility = Visibility.Collapsed;
            blahaj.Visibility = Visibility.Collapsed;
            postavicka.Visibility = Visibility.Collapsed;
            ketamin.Visibility = Visibility.Collapsed;
            nuzimg.Visibility = Visibility.Collapsed;
            pantofleimg.Visibility = Visibility.Collapsed;
            lahevimg.Visibility = Visibility.Collapsed;
            nemcinaimg.Visibility = Visibility.Collapsed;
            ponozkaimg.Visibility = Visibility.Collapsed;
            blahajimg.Visibility = Visibility.Collapsed;
            animeimg.Visibility = Visibility.Collapsed;
            ketaminimg.Visibility = Visibility.Collapsed;

            if (nuz.Content == null)
            {
                MessageBox.Show("sex");
            }

            if (i == 7)
            {
                MessageBox.Show("sex");
            }


        }
        public void hid()
        {
            detektiv.Visibility = Visibility.Collapsed;
            dal.Visibility = Visibility.Collapsed;
            jmenovka.Visibility = Visibility.Collapsed;
            textbox.Text = "";
            find.Visibility = Visibility.Visible;
            nuz.Visibility = Visibility.Visible;
            pantofle.Visibility = Visibility.Visible;
            lahev.Visibility = Visibility.Visible;
            nemcina.Visibility = Visibility.Visible;
            ponozka.Visibility = Visibility.Visible;
            blahaj.Visibility = Visibility.Visible;
            postavicka.Visibility = Visibility.Visible;
            ketamin.Visibility = Visibility.Visible;
            nuzimg.Visibility = Visibility.Visible;
            pantofleimg.Visibility = Visibility.Visible;
            lahevimg.Visibility = Visibility.Visible;
            nemcinaimg.Visibility = Visibility.Visible;
            ponozkaimg.Visibility = Visibility.Visible;
            blahajimg.Visibility = Visibility.Visible;
            animeimg.Visibility = Visibility.Visible;
            ketaminimg.Visibility = Visibility.Visible;
        }

        public void checkNull()
        {
            if (nuz.Content == null && pantofle.Content == null && lahev.Content == null && nemcina.Content == null && ponozka.Content == null && blahaj.Content == null && postavicka.Content == null && ketamin.Content == null)
            {
                detektiv.Visibility = Visibility.Visible;
                jmenovka.Visibility = Visibility.Visible;
                find.Visibility = Visibility.Collapsed;

                textbox.Text = "Tenhle nůž je skoro určitě vražedná zbraň! Přesně takhle velké bodné rany v sobě má oběť. Hmmm... Nůž byl dobře očištěn, otisky žádné. Na noži jsou ale vyrité iniciály jména. Iniciála jména na noži začíná na V, jméno vraha tedy praděpodobně taky. Měl bych pozorně vyslechnout všechny podezřelé se jménem začínajícím na V.";
            }
        }

        public void dal_Click(object sender, RoutedEventArgs e)
        {
            hid();
        }

        public void nuzimg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            nuz.Content = null;
            nuzimg.Visibility = Visibility.Collapsed;
            checkNull();
        }

        public void pantofleimg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pantofle.Content = null;
            pantofleimg.Visibility = Visibility.Collapsed;
            checkNull();

        }

        public void lahevimg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lahev.Content = null;
            lahevimg.Visibility = Visibility.Collapsed;
            checkNull();
        }

        public void nemcinaimg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            nemcina.Content = null;
            nemcinaimg.Visibility = Visibility.Collapsed;
            checkNull();
        }

        public void ponozkaimg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ponozka.Content = null;
            ponozkaimg.Visibility = Visibility.Collapsed;
            checkNull();

        }

        public void blahajimg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            blahaj.Content = null;
            blahajimg.Visibility = Visibility.Collapsed;
            checkNull();

        }

        public void animeimg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            postavicka.Content = null;
            animeimg.Visibility = Visibility.Collapsed;
            checkNull();

        }

        public void ketaminimg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ketamin.Content = null;
            ketaminimg.Visibility = Visibility.Collapsed;
            checkNull();

        }

        private void getout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Venek("dum"));
        }
    }
}
