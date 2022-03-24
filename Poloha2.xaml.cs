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
using System.Text.Json;
using System.Windows.Navigation;
using Newtonsoft.Json;
using System.IO;

namespace Hra
{
    /// <summary>
    /// Interakční logika pro Poloha2.xaml
    /// </summary>
    
public partial class Poloha2 : Page
    {
        public List<Slova> jsonFromFile;
        public int but;
        public string texta;
        public int i = 0;

        public Poloha2()
        {
            InitializeComponent();
            Hidoption();
            DetektivS();
            PostavavlevoS();

            texta = File.ReadAllText(@"./json/text.json");
            jsonFromFile = JsonConvert.DeserializeObject<List<Slova>>(texta);
        }

        public void Hidoption()
        {
            select.Visibility = System.Windows.Visibility.Hidden;
            leftBut.Visibility = System.Windows.Visibility.Hidden;
            rightBut.Visibility = System.Windows.Visibility.Hidden;
            textbox.Visibility = System.Windows.Visibility.Visible;
            dal.Visibility = System.Windows.Visibility.Visible;
            jmenovka.Visibility = System.Windows.Visibility.Visible;
        }
        public void Hidtext()
        {
            select.Visibility = System.Windows.Visibility.Visible;
            leftBut.Visibility = System.Windows.Visibility.Visible;
            rightBut.Visibility = System.Windows.Visibility.Visible;
            textbox.Visibility = System.Windows.Visibility.Hidden;
            dal.Visibility = System.Windows.Visibility.Hidden;
            jmenovka.Visibility = System.Windows.Visibility.Hidden;
        }

        public void DetektivS()
        {
            postavavpravo.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/detektiv.png", UriKind.Relative)));
        }
        public void PostavavlevoS()
        {
            postavavlevo.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/policeman.png", UriKind.Relative)));
        }

        public void Dal_Click(object sender, RoutedEventArgs e)
        {
            i++;
            Hidoption();

            if (i == 1)
            {
                textbox.Text = jsonFromFile[1].Text;
                jmenovka.Text = jsonFromFile[1].Jmenovka;


            }
            else if (i == 2)
            {
                textbox.Text = jsonFromFile[2].Text;
                jmenovka.Text = jsonFromFile[2].Jmenovka;
                PostavavlevoS();

            }
            else if (i == 3)
            {
                textbox.Text = jsonFromFile[3].Text;
                jmenovka.Text = jsonFromFile[3].Jmenovka;
            }
            else
            {
                Hidtext();
                Optionbox();
                

            }
        }

        public void Optionbox()
        {
            select.Text = "co ted hmmm";
            leftBut.Content = "ne";
            rightBut.Content = "ano";
        }
        public void LeftBut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightBut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
