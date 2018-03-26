using CoderDojoApp.Network.Response;
using CoderDojoApp.UI.EventPage.MVP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CoderDojoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EventPage : Page, IEventDetailView
    {
        public EventPage()
        {
            this.InitializeComponent();
        }

        public void showError(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void showEvent(DojoEvent dojoEvent)
        { 
            TitleEvent.Text = dojoEvent.Title;
            Run run = new Run
            {
                Text = dojoEvent.Description
            };
            DescriptionEvent.Inlines.Add(run);
            /*
            DateTImeDetail.Text = dojoEvent.StartTime.ToString();
            LogoDetail.Source = new BitmapImage(new Uri(dojoEvent.Logo));
            */

            LoadMap(dojoEvent.Location);
        }

        private async void LoadMap(DojoLocation location)
        {
            Geopoint eventLocation = GenerateGeoPoint(location);
            MapIcon myPOI = new MapIcon { Location = eventLocation,
                NormalizedAnchorPoint = new Point(0.5, 1.0),
                Title = "Coder Dojo!", ZIndex = 0 };
            EventMap.MapElements.Add(myPOI);
            await EventMap.TrySetSceneAsync(MapScene.CreateFromLocationAndRadius(eventLocation, 150));
        }

        private static Geopoint GenerateGeoPoint(DojoLocation location)
        {
            return new Geopoint(new BasicGeoposition()
            {
                Latitude = location.Latitude,
                Longitude = location.Longitude
            });
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            showEvent((DojoEvent)e.Parameter);
        }
    }
}
