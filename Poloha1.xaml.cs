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
    /// Interakční logika pro Poloha1.xaml
    /// </summary>
    public partial class Poloha1 : Page
    {
        //public string texta;
        public List<Slova> jsonFromFile;
        public int but;
        public string texta;
        public int i = 0;

        public Poloha1()
        {
            

            InitializeComponent();
            //BitmapImage mainimg = new BitmapImage();

            // jsonFromFile = JsonConvert.DeserializeObject<List<Slova>>(texta);

            texta = File.ReadAllText(@"./json/text.json");
            jsonFromFile = JsonConvert.DeserializeObject<List<Slova>>(texta);


            //mainimg.UriSource = new Uri(@"./photos/detektiv.png", UriKind.Relative);
            Button btn = new Button();
            btn.Name = "dal";
            btn.Click += Dal_Click;

            //postavavpravo.Source = new BitmapImage(new Uri(@"./photos/detektiv.png", UriKind.Relative));
            //mrtvola.Source = new BitmapImage(new Uri(@"./photos/bite.jfif", UriKind.Relative));
            textbox.Text = jsonFromFile[0].Text;
            jmenovka.Text = jsonFromFile[0].Jmenovka;


            DetektivS();
            MrtvolaS();
            BackdropLib();
            //PostavavlevoS();


            Hidoption();

        }

        public void DetektivS()
        {
            postavavpravo.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/detektiv.png", UriKind.Relative)));
        }

        public void MrtvolaS()
        {
            mrtvola.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/mrtvola.png", UriKind.Relative)));
        }
        public void BackdropLib()
        {
            background.ImageSource = new BitmapImage(new Uri(@"./photos/library1.jpg", UriKind.Relative));
        }
        public void PostavavlevoS()
        {
            postavavlevo.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/policeman.png", UriKind.Relative)));
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



        public void Optionbox()
        {
            select.Text = "Chcete postoupit do další lokace?";
            leftBut.Content = "ne";
            rightBut.Content = "ano";
        }


        public void Click()
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
                mrtvola.Source = null;
                PostavavlevoS();

            }
            else if (i == 3)
            {
                textbox.Text = jsonFromFile[3].Text;
                jmenovka.Text = jsonFromFile[3].Jmenovka;
            }
            else
            {
                Optionbox();
                Hidtext();

            }
            
        }


        public void Dal_Click(object sender, RoutedEventArgs e)
        {
            Click();
            
        }

        

        public void LeftBut_Click(object sender, RoutedEventArgs e)
        {
            
            Hidoption();
            
            

        }

        private void RightBut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService next = NavigationService.GetNavigationService(this);
            next.Navigate(new Uri("Poloha2.xaml", UriKind.Relative));


        }
    }
}
