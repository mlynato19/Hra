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
        public bool done;

        public List<Slova> jsonFromFile;
        public List<Slova> jsonFromFileB;
        public List<Slova> jsonFromFileC;
        public List<Slova> jsonFromFileD;
        public List<Slova> jsonFromFileE;
        public List<Slova> jsonFromFileF;
        public List<Slova> jsonFromFileG;
        
        public string texta;
        public string textb;
        public string textc;
        public string textd;
        public string texte;
        public string textf;
        public string textg;

        public int pozice = 0;
        public int i = 0;
        //pozice 0 = intro, pozice 1 = vnitrek, pozice 2 = zahrada, pozice 3 = hospoda, pozice 4 = marie, pozice 5 = viktorie, pozice 6 = vojtech, pozice 7 = detektivna, pozice 8 = ending


        public Poloha2(string mistnost)
        {
            
            InitializeComponent();
            mrtvola.Visibility = Visibility.Collapsed;
            texta = File.ReadAllText(@"./json/introtext.json");
            textb = File.ReadAllText(@"./json/vnitrektext.json");
            textc = File.ReadAllText(@"./json/zahradatext.json");
            textd = File.ReadAllText(@"./json/hospodatext.json");
            texte = File.ReadAllText(@"./json/marietext.json");
            textf = File.ReadAllText(@"./json/viktorietext.json");
            textg = File.ReadAllText(@"./json/vojtechtext.json");
            jsonFromFile = JsonConvert.DeserializeObject<List<Slova>>(texta);
            jsonFromFileB = JsonConvert.DeserializeObject<List<Slova>>(textb);
            jsonFromFileC = JsonConvert.DeserializeObject<List<Slova>>(textc);
            jsonFromFileD = JsonConvert.DeserializeObject<List<Slova>>(textd);
            jsonFromFileE = JsonConvert.DeserializeObject<List<Slova>>(texte);
            jsonFromFileF = JsonConvert.DeserializeObject<List<Slova>>(textf);
            jsonFromFileG = JsonConvert.DeserializeObject<List<Slova>>(textg);

            marieBut.Visibility = Visibility.Collapsed;
            viktorieBut.Visibility = Visibility.Collapsed;
            vojtechBut.Visibility = Visibility.Collapsed;
            getout.Visibility = Visibility.Collapsed;

            if (mistnost == "intro")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/library1.jpg", UriKind.Relative));
                pozice = 0;
                postavavlevo.Visibility = Visibility.Collapsed;
                mrtvola.Visibility = Visibility.Visible;
                textbox.Text = jsonFromFile[i].Text;
                jmenovka.Text = jsonFromFile[i].Jmenovka;

            }
            if (mistnost == "vnitrek")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/interior.jpg", UriKind.Relative));
                textbox.Text = jsonFromFileB[i].Text;
                jmenovka.Text = jsonFromFileB[i].Jmenovka;
                pozice = 1;
            }
            else if (mistnost == "zahrada")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/Victorian-Garden-3.jpg", UriKind.Relative));
                pozice = 2;
                textbox.Text = jsonFromFileC[i].Text;
                jmenovka.Text = jsonFromFileC[i].Jmenovka;
            }
            else if (mistnost == "hospoda") 
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/pub1.jpg", UriKind.Relative));
                pozice = 3;
                textbox.Text = jsonFromFileD[i].Text;
                jmenovka.Text = jsonFromFileD[i].Jmenovka;
            }
            else if (mistnost == "marie")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/dum_marie.jpg", UriKind.Relative));
                pozice = 4;
                textbox.Text = jsonFromFileE[i].Text;
                jmenovka.Text = jsonFromFileE[i].Jmenovka;
            }
            else if (mistnost == "viktorie")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/dum_viktorie.jpg", UriKind.Relative));
                pozice = 5;
                textbox.Text = jsonFromFileF[i].Text;
                jmenovka.Text = jsonFromFileF[i].Jmenovka;
            }
            else if (mistnost == "vojtech")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/victorian-car.jpg", UriKind.Relative));
                pozice = 6;
                textbox.Text = jsonFromFileG[i].Text;
                jmenovka.Text = jsonFromFileG[i].Jmenovka;
            }
            else if (mistnost == "detektivna")
            {
                background.ImageSource = new BitmapImage(new Uri(@"./photos/detektivna.jpg", UriKind.Relative));
                postavavlevo.Visibility = Visibility.Collapsed;
                pozice = 7;
                textbox.Text = "Moje kancelář. Až vyřeším kdo vraždu spáchal, zapíšu to zde a policie už se o vraha postará.";
                jmenovka.Text = "Detektiv";
            }

            Hidoption();
            DetektivS();
            PostavavlevoS();
            MrtvolaS();
            
        }




        public void Dal_Click(object sender, RoutedEventArgs e)
        {
            
            i++;

            if (pozice == 0)
            {
                textbox.Text = jsonFromFile[i].Text;
                jmenovka.Text = jsonFromFile[i].Jmenovka;
                if (i == 2)
                {

                    PostavavlevoS();
                    mrtvola.Visibility = Visibility.Collapsed;
                    postavavlevo.Visibility = Visibility.Visible;
                } else if (i == 7)
                {
                    NavigationService.Navigate(new Poloha2("vnitrek"));
                }
                
            }
            else if (pozice == 1)
            {
                
                textbox.Text = jsonFromFileB[i].Text;
                jmenovka.Text = jsonFromFileB[i].Jmenovka;
                if (i == 3)
                {
                    Hidtext();
                    Optionbox();
                } 
                else if (i >= 5)
                {
                    getout.Visibility = Visibility.Visible;
                    i--;
                }

            }
            else if (pozice == 2)
            {
                textbox.Text = jsonFromFileC[i].Text;
                jmenovka.Text = jsonFromFileC[i].Jmenovka;
                if (i >= 5)
                {
                    getout.Visibility = Visibility.Visible;
                    i--;
                }
                
            }
            else if (pozice == 3)
            {
                textbox.Text = jsonFromFileD[i].Text;
                jmenovka.Text = jsonFromFileD[i].Jmenovka;
                
            }
            else if (pozice == 4)
            {
                textbox.Text = jsonFromFileE[i].Text;
                jmenovka.Text = jsonFromFileE[i].Jmenovka;

            }
            else if (pozice == 5)
            {
                textbox.Text = jsonFromFileF[i].Text;
                jmenovka.Text = jsonFromFileF[i].Jmenovka;

            }
            else if (pozice == 6)
            {
                textbox.Text = jsonFromFileG[i].Text;
                jmenovka.Text = jsonFromFileG[i].Jmenovka;

            }
            else if (pozice is 7 or 8)
            {
                Hidtext();
                Optionbox();
            }

        }

        public void Hidoption()
        {
            select.Visibility = Visibility.Collapsed;
            leftBut.Visibility = Visibility.Collapsed;
            rightBut.Visibility = Visibility.Collapsed;
            textbox.Visibility = Visibility.Visible;
            dal.Visibility = Visibility.Visible;
            jmenovka.Visibility = Visibility.Visible;
        }
        public void Hidtext()
        {
            select.Visibility = Visibility.Visible;
            leftBut.Visibility = Visibility.Visible;
            rightBut.Visibility = Visibility.Visible;
            textbox.Visibility = Visibility.Collapsed;
            dal.Visibility = Visibility.Collapsed;
            jmenovka.Visibility = Visibility.Collapsed;
        }

        public void DetektivS()
        {
            postavavpravo.Source = new BitmapImage(new Uri(@"./photos/detektiv.png", UriKind.Relative));
        }

        public void MrtvolaS()
        {
            mrtvola.Source = new BitmapImage(new Uri(@"./photos/mrtvola.png", UriKind.Relative));
        }

        public void PostavavlevoS()
        {
            if (pozice == 0)
            {
                postavavlevo.Source = new BitmapImage(new Uri(@"./photos/policeman.png", UriKind.Relative));
            } 
            else if (pozice == 1)
            {
                postavavlevo.Source = new BitmapImage(new Uri(@"./photos/child.png", UriKind.Relative));
            } 
            else if (pozice == 2)
            {
                postavavlevo.Source = new BitmapImage(new Uri(@"./photos/gardener.png", UriKind.Relative));
            } 
            else if (pozice == 3)
            {
                postavavlevo.Source = new BitmapImage(new Uri(@"./photos/cisnik.png", UriKind.Relative));
            }
            else if (pozice == 4)
            {
                postavavlevo.Source = new BitmapImage(new Uri(@"./photos/marie.png", UriKind.Relative));
            }
            else if (pozice == 5)
            {
                postavavlevo.Source = new BitmapImage(new Uri(@"./photos/viktorie.png", UriKind.Relative));
            }
            else if (pozice == 6)
            {
                postavavlevo.Source = new BitmapImage(new Uri(@"./photos/vojtech.png", UriKind.Relative));
            }

        }
        


        public void Optionbox()
        {
            if (pozice == 1)
            {
                select.Text = "Na co se zeptám?";
                leftButText.Text = "Kolik mu bylo let?";
                rightButText.Text = "Měl nějaké nepřátele?";
            }
            else if (pozice == 2)
            {
                select.Text = "Na co se zeptám?";
                leftButText.Text = "Víme, jak dlouho je mrtvý?";
                rightButText.Text = "Měl nějaké nepřátele?";
            }
            else if (pozice == 3)
            {

            }
            else if (pozice == 4)
            {

            }
            else if (pozice == 5)
            {

            }
            else if (pozice == 6)
            {

            }
            else if (pozice == 7)
            {
                select.Text = "Obvinit vraha?";
                leftButText.Text = "Ještě ne";
                rightButText.Text = "Ano";
            }
            else if (pozice == 8)
            {
                select.Text = "Chcete se vrátit na úvodní stranu?";
                leftButText.Text = "Ne";
                rightButText.Text = "Ano";
            }


        }
        public void LeftBut_Click(object sender, RoutedEventArgs e)
        {
            if (pozice == 1)
            {
                Hidoption();
                jmenovka.Text = "Syn";
                textbox.Text = "44.";

            }
            else if (pozice == 2)
            {

            }
            else if (pozice == 3)
            {

            }
            else if (pozice == 4)
            {

            }
            else if (pozice == 5)
            {

            }
            else if (pozice == 6)
            {

            }
            else if (pozice == 7)
            {

            }
            else if (pozice == 8)
            {
                Hidoption();
                jmenovka.Visibility = Visibility.Collapsed;
            }

            
        }

        private void RightBut_Click(object sender, RoutedEventArgs e)
        {
            //Hidoption();
            
            if (pozice == 1)
            {
                Hidoption();
                jmenovka.Text = "Syn";
                textbox.Text = "Nevím o nikom, ale poslední dobou měl neshody s Marií a Viktorií. A ještě je tu Vojtěch, ten tátu neměl nikdy v oblibě.";
            }
            else if (pozice == 2)
            {

            }
            else if (pozice == 3)
            {

            }
            else if (pozice == 4)
            {

            }
            else if (pozice == 5)
            {

            }
            else if (pozice == 6)
            {

            }
            else if (pozice == 7)
            {
                rightBut.Visibility = Visibility.Collapsed;
                leftBut.Visibility = Visibility.Collapsed;

                marieBut.Visibility = Visibility.Visible;
                viktorieBut.Visibility = Visibility.Visible;
                vojtechBut.Visibility = Visibility.Visible;
            }
            else if (pozice == 8)
            {
                NavigationService next = NavigationService.GetNavigationService(this);
                next.Navigate(new Uri("Start.xaml", UriKind.Relative));
            }
        }

        public void Getout_Click(object sender, RoutedEventArgs e)
        {
            if (pozice == 1)
            {
                NavigationService.Navigate(new Venek("vnitrek"));
            } 
            else if (pozice == 2)
            {
                NavigationService.Navigate(new Venek("zahrada"));
            } 
            else if (pozice == 3)
            {
                NavigationService.Navigate(new Venek("hospoda"));
            }
            else if (pozice == 4)
            {
                NavigationService.Navigate(new Venek("marie"));
            }
            else if (pozice == 5)
            {
                NavigationService.Navigate(new Venek("viktorie"));
            }
            else if (pozice == 6)
            {
                NavigationService.Navigate(new Venek("vojtech"));
            }
            else if (pozice == 7)
            {
                NavigationService.Navigate(new Venek("detektivna"));
            }
            
        }

        private void viktorieBut_Click(object sender, RoutedEventArgs e)
        {
            Hidoption();

            pozice = 8;

            marieBut.Visibility = Visibility.Collapsed;
            viktorieBut.Visibility = Visibility.Collapsed;
            vojtechBut.Visibility = Visibility.Collapsed;
            postavavlevo.Visibility = Visibility.Visible;

            jmenovka.Visibility = Visibility.Collapsed;

            getout.Visibility = Visibility.Collapsed;

            postavavpravo.Visibility = Visibility.Collapsed;
            background.ImageSource = new BitmapImage(new Uri(@"./photos/jail.jpg", UriKind.Relative));
            postavavlevo.Source = new BitmapImage(new Uri(@"./photos/viktorie.png", UriKind.Relative));

            textbox.Text = "Vyřešil jste záhadu! Vrahem byla Viktorie. Neměla žádné alibi a měla největší motiv vraždu spáchat.";
        }

        public void Incorrect()
        {
            Hidoption();

            pozice = 8;
            marieBut.Visibility = Visibility.Collapsed;
            viktorieBut.Visibility = Visibility.Collapsed;
            vojtechBut.Visibility = Visibility.Collapsed;
            jmenovka.Visibility = Visibility.Collapsed;
            getout.Visibility= Visibility.Collapsed;
            postavavpravo.Visibility = Visibility.Collapsed;

            textbox.Text = "Nebylo nalezeno dost důkazů pro tohoto podezřelého. Pravý vrah utekl a vražda nebyla vyřešena.";
        }

        private void marieBut_Click(object sender, RoutedEventArgs e)
        {
            Incorrect();
        }

        private void vojtechBut_Click(object sender, RoutedEventArgs e)
        {
            Incorrect();
        }
    }
}
