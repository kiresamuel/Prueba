using PruebaUWP.ViewModels;
using System;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.Media.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PruebaUWP
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Video : Page
    {
        public Video()
        {
            this.InitializeComponent();
            DataContext = new Trailer_VM();

            var bounds = ApplicationView.GetForCurrentView().VisibleBounds;
            var scaleFactor = DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
            var size = new Size(bounds.Width * scaleFactor, bounds.Height * scaleFactor);
            this.Player.Height = size.Height - 30;
            this.Player.Width = size.Width;

            Player.Source = MediaSource.CreateFromUri(
                new Uri("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4"));
            Player.AutoPlay = true;
        }
    }
}
