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
                NavigationService next = NavigationService.GetNavigationService(this);
                next.Navigate(new Uri("Poloha2.xaml", UriKind.Relative));
            }

            if (ktop <= -180 && kleft >= -460 && kleft <= -350)
            {
                MessageBox.Show("a");
            }

            if (ktop <= -180 && kleft >= -180 && kleft <= -90)
            {
                MessageBox.Show("b");
            }

            if (ktop <= -180 && kleft >= 80 && kleft <= 170)
            {
                MessageBox.Show("c");
            }

            if (ktop <= -180 && kleft >= 80 && kleft <= 170)
            {
                MessageBox.Show("d");
            }

            if (ktop <= -80 && kleft >= 410 && kleft <= 720)
            {
                NavigationService next = NavigationService.GetNavigationService(this);
                next.Navigate(new Uri("Hospoda.xaml", UriKind.Relative));
            }

            if (ktop >= 110 && kleft >= -520 && kleft <= -350)
            {
                MessageBox.Show("f");
            }

            if (ktop >= 110 && kleft >= -720 && kleft <= -610)
            {
                MessageBox.Show("f");
            }
        }

        
    }
}