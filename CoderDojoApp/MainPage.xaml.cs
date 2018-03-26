using CoderDojoApp.MVP;
using CoderDojoApp.Network.API;
using CoderDojoApp.Network.Response;
using CoderDojoApp.UI.MVP.ListPage;
using Microsoft.Graphics.Canvas.Effects;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace CoderDojoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, IDojoEventListView
    {
        private DojoEventListPresenter presenter;
        private DojoEventListModel model;
        public MainPage()
        {

            this.InitializeComponent();

        }



        private void FooPage()
        {
            double lat = 43.65820;
            double lon = 11.30649;
            model = new DojoEventListModel(new DojoAPI());
            presenter = new DojoEventListPresenter(model, this);
            Debug.Write(presenter);
            presenter.SearchEvents(lat, lon, 150);
        }
        public void RequestUserPrefs()
        {
            throw new NotImplementedException();
        }

        public void ShowError(Exception ex)
        {
            throw new NotImplementedException();
        }


        public void ShowEvents(List<DojoEvent> events)
        {
            ListPane.ItemsSource = events;
        }

        private void OnEventClick(object sender, ItemClickEventArgs e)
        {
            DescriptionFrame.Navigate(typeof(EventPage), (DojoEvent)e.ClickedItem);
        }

        private void LoadPage(object sender, RoutedEventArgs e)
        {
            progressRing.Visibility = Visibility.Visible;
            splitView.Visibility = Visibility.Collapsed;
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
            }
            else
            {
                splitView.Visibility = Visibility.Visible;
                progressRing.Visibility = Visibility.Collapsed;
                FooPage();
            }
        }
    }
}
