using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Tasks;

namespace MejoresPeliculasGangsters
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void controlPivot_LoadingPivotItem(object sender, PivotItemEventArgs e)
        {
            switch (this.controlPivot.SelectedIndex)
            {
                case 0:
                    changeBackground("Images/principal.jpg");
                    break;
                case 1:
                    changeBackground("Images/elPadrino.jpg");
                    break;
                case 2:
                    changeBackground("Images/onceUponTime.jpg");
                    break;
                case 3:
                    changeBackground("Images/scarface.jpg");
                    break;
                case 4:
                    changeBackground("Images/ciudadDeDios.jpg");
                    break;
                case 5:
                    changeBackground("Images/carlitosWay.jpg");
                    break;
                case 6:
                    changeBackground("Images/Goodfellas.jpg");
                    break;
            }

        }

        private void changeBackground(string str)
        {
            Image myImage3 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.UriSource = new Uri(str, UriKind.Relative);
            myImage3.Source = bi3;
            ImageBrush img = new ImageBrush();
            img.ImageSource = bi3;
            this.controlPivot.Background = img;
        }

        private void FirstListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void elPadrino_Tap(object sender, GestureEventArgs e)
        {
            this.controlPivot.SelectedIndex = 1;
        }

        private void eraseUnaVez_Tap(object sender, GestureEventArgs e)
        {
            this.controlPivot.SelectedIndex = 2;
        }

        private void scarface_Tap(object sender, GestureEventArgs e)
        {
            this.controlPivot.SelectedIndex = 3;
        }

        private void goodFellas_Tap(object sender, GestureEventArgs e)
        {
            this.controlPivot.SelectedIndex = 6;
        }

        private void carlitos_Tap(object sender, GestureEventArgs e)
        {
            this.controlPivot.SelectedIndex = 5;
        }

        private void ciudadDios_Tap(object sender, GestureEventArgs e)
        {
            this.controlPivot.SelectedIndex = 4;
        }

        private void iconMenu_Click(object sender, EventArgs e)
        {
            this.controlPivot.SelectedIndex = 0;
        }

        private void iconContacto_Click(object sender, EventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();

            emailComposeTask.Subject = "message subject";
            emailComposeTask.Body = "message body";
            emailComposeTask.To = "rob_bj92@hotmail.com";

            emailComposeTask.Show();

        }

        private void iconAcercaDe_Click(object sender, EventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }

    }
}