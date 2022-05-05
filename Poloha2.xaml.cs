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
        //public int location = 1;

        public List<Slova> jsonFromFile;
        public int but;
        public string texta;
        public int pozice = 0;
        //pozice 0 = intro, pozice 1 = vnitrek, pozice 2 = hospoda, pozice 3 = zahrada


        public Poloha2(string mistnost)
        {
            
            InitializeComponent();
            mrtvola.Visibility = Visibility.Collapsed;
            texta = File.ReadAllText(@"./json/text.json");
            jsonFromFile = JsonConvert.DeserializeObject<List<Slova>>(texta);

            if (mistnost == "intro")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/library1.jpg", UriKind.Relative));
                getout.Visibility = System.Windows.Visibility.Hidden;
                pozice = 0;
                postavavlevo.Visibility = Visibility.Collapsed;
                mrtvola.Visibility = Visibility.Visible;
                textbox.Text = jsonFromFile[0].Text;
                jmenovka.Text = jsonFromFile[0].Jmenovka;

            }
            if (mistnost == "vnitrek")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/interior.jpg", UriKind.Relative));
                
                pozice = 1;
                

            } else if (mistnost == "hospoda") 
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/pub1.jpg", UriKind.Relative));
                pozice = 2;
            }
            else if (mistnost == "zahrada")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/Victorian-Garden-3.jpg", UriKind.Relative));
                pozice = 3;
            }

            Hidoption();
            DetektivS();
            PostavavlevoS();
            MrtvolaS();
            
        }



        public int i = 0;
        public void Dal_Click(object sender, RoutedEventArgs e)
        {
            i++;
            Hidoption();


            if (pozice == 0)
            {
                if (i == 1)
                {
                    textbox.Text = "pes";
                    jmenovka.Text = jsonFromFile[1].Jmenovka;
                    

                }
                else if (i == 2)
                {
                    textbox.Text = jsonFromFile[2].Text;
                    jmenovka.Text = jsonFromFile[2].Jmenovka;

                    PostavavlevoS();
                    mrtvola.Visibility = Visibility.Collapsed;
                    postavavlevo.Visibility = Visibility.Visible;
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
            else if (pozice == 1)
            {

                if (i == 1)
                {
                    Hidoption();
                    textbox.Text = /*jsonFromFile[1].Text*/"vnitrtek";
                    jmenovka.Text = jsonFromFile[1].Jmenovka;


                }
                else if (i == 2)
                {
                    textbox.Text = "owo";
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
            else if (pozice == 2)
            {

                if (i == 1)
                {
                    Hidoption();
                    textbox.Text = /*jsonFromFile[1].Text*/"hospoda uaaaaaa";
                    jmenovka.Text = jsonFromFile[1].Jmenovka;


                }
                else if (i == 2)
                {
                    textbox.Text = "owo";
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
            else if (pozice == 3)
            {

                if (i == 1)
                {
                    Hidoption();
                    textbox.Text = /*jsonFromFile[1].Text*/"ZAHRADA";
                    jmenovka.Text = jsonFromFile[1].Jmenovka;


                }
                else if (i == 2)
                {
                    textbox.Text = "owo";
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
            postavavpravo.ImageSource = new BitmapImage(new Uri(@"./photos/detektiv.png", UriKind.Relative));


            //postavavpravo.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/detektiv.png", UriKind.Relative)));
        }

        public void MrtvolaS()
        {
            mrtvola.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/mrtvola.png", UriKind.Relative)));
        }

        public void PostavavlevoS()
        {
            if (pozice == 0)
            {
                postavavlevo.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/policeman.png", UriKind.Relative)));
            } else if (pozice == 1)
            {
                postavavlevo.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/policeman.png", UriKind.Relative)));
            } else if (pozice == 2)
            {
                postavavlevo.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/cisnik.png", UriKind.Relative)));
            } else if (pozice == 3)
            {
                postavavlevo.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/videohra/Hra/photos/policeman.png", UriKind.Relative)));
            }

            
        }
        


        public void Optionbox()
        {
            select.Text = "Na co se zeptám?";
            leftButText.Text = "Víme, jak dlouho je mrtvý?";
            rightButText.Text = "Měl nějaké nepřátele?";
        }
        public void LeftBut_Click(object sender, RoutedEventArgs e)
        {
            Hidoption();
            textbox.Text = jsonFromFile[1].Text;
            jmenovka.Text = jsonFromFile[1].Jmenovka;
        }

        private void RightBut_Click(object sender, RoutedEventArgs e)
        {
            Hidoption();
            NavigationService.Navigate(new Poloha2("vnitrek"));
        }

        public void Getout_Click(object sender, RoutedEventArgs e)
        {
            if (pozice == 1)
            {
                NavigationService.Navigate(new Venek("vnitrek"));
            } else if (pozice == 2)
            {
                NavigationService.Navigate(new Venek("hospoda"));
            } else if (pozice == 3)
            {
                NavigationService.Navigate(new Venek("zahrada"));
            }
        }
    }
}
