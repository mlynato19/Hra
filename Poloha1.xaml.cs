﻿using System;
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

        public Poloha1()
        {

            InitializeComponent();
            BitmapImage mainimg = new BitmapImage();



            // jsonFromFile = JsonConvert.DeserializeObject<List<Slova>>(texta);

            texta = File.ReadAllText("C:/Users/tom/DownloadWin/videohra/json/text.json");
            jsonFromFile = JsonConvert.DeserializeObject<List<Slova>>(texta);



            mainimg.UriSource = new Uri("C:/Users/tom/DownloadWin/videohra/photos/SpringTrapScrappy.png");
            Button btn = new Button();
            btn.Name = "dal";
            btn.Click += dal_Click;
            background.ImageSource = new BitmapImage(new Uri(@"C:/Users/tom/DownloadWin/videohra/photos/library1.jpg"));
            postavavpravo.Source = new BitmapImage(new Uri(@"C:/Users/tom/DownloadWin/videohra/photos/detektiv.png"));
            //postavavlevo.Source = new BitmapImage(new Uri(@"C:/Users/tom/DownloadWin/videohra/photos/detektiv.png"));
            mrtvola.Source = new BitmapImage(new Uri(@"C:/Users/tom/DownloadWin/videohra/photos/bite.jfif"));
            textbox.Text = jsonFromFile[0].Text;
            jmenovka.Text = jsonFromFile[0].Jmenovka;




            hidoption();



        }


        public void hidoption()
        {
            select.Visibility = System.Windows.Visibility.Hidden;
            leftBut.Visibility = System.Windows.Visibility.Hidden;
            rightBut.Visibility = System.Windows.Visibility.Hidden;
            textbox.Visibility = System.Windows.Visibility.Visible;
            dal.Visibility = System.Windows.Visibility.Visible;
            jmenovka.Visibility = System.Windows.Visibility.Visible;

        }
        public void hidtext()
        {
            select.Visibility = System.Windows.Visibility.Visible;
            leftBut.Visibility = System.Windows.Visibility.Visible;
            rightBut.Visibility = System.Windows.Visibility.Visible;
            textbox.Visibility = System.Windows.Visibility.Hidden;
            textbox.Visibility = System.Windows.Visibility.Hidden;
            jmenovka.Visibility = System.Windows.Visibility.Hidden;
        }

        public void optionbox()
        {
            select.Text = "pis";
            leftBut.Content = "ne";
            rightBut.Content = "ano";
        }


        public int i = 0;
        private void dal_Click(object sender, RoutedEventArgs e)
        {
            i++;
            

            if (i == 1)
            {
                textbox.Text = jsonFromFile[1].Text;
                

            }
            else if (i == 2)
            {
                textbox.Text = jsonFromFile[2].Text;
                optionbox();
                hidtext();
                mrtvola.Source = null;
            }
            else if (i == 3)
            {
                textbox.Text = jsonFromFile[3].Text;
                hidoption();
                postavavlevo.Source = new BitmapImage(new Uri(@"C:/Users/tom/DownloadWin/videohra/photos/detektiv.png"));
                //background.ImageSource = new BitmapImage(new Uri(@"R:/videohra/photos/interior.jpg"));
            }
            else
            {

                
            }




        }

        private void leftBut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rightBut_Click(object sender, RoutedEventArgs e)
        {
            i++;
            hidtext();
        }
    }
}
