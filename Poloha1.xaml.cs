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
using Newtonsoft.Json;
using System.IO;
namespace Hra
{
    /// <summary>
    /// Interakční logika pro Poloha1.xaml
    /// </summary>
    public partial class Poloha1 : Page
    {
        public string texta;
        public List<Slova> jsonFromFile;
        public Poloha1()
        {
            InitializeComponent();
            BitmapImage mainimg = new BitmapImage();

            texta = File.ReadAllText("R:/videohra/text.json");
            jsonFromFile = JsonConvert.DeserializeObject<List<Slova>>(texta);

            mainimg.UriSource = new Uri("R:/videohra/photos/SpringTrapScrappy.png");
            Button btn = new Button();
            btn.Name = "dal";
            btn.Click += dal_Click;
            background.ImageSource = new BitmapImage(new Uri(@"R:/videohra/photos/library1.jpg"));
            postavavpravo.Source = new BitmapImage(new Uri(@"R:/videohra/photos/SpringTrapScrappy.png"));
            mrtvola.Source = new BitmapImage(new Uri(@"R:/videohra/photos/bite.jfif"));
            text.Text = jsonFromFile[0].Text;

        }





        public int i = 0;
        private void dal_Click(object sender, RoutedEventArgs e)
        {
            i++;
            if (i == 1)
            {
                text.Text = jsonFromFile[1].Text;
            }
            else if (i == 2)
            {
                text.Text = jsonFromFile[2].Text;
                mrtvola.Source = null;
            }
            else if (i == 3)
            {
                text.Text = jsonFromFile[3].Text;
                //background.ImageSource = new BitmapImage(new Uri(@"R:/videohra/photos/interior.jpg"));
            }
            else
            {

                
            }




        }
    }
}
