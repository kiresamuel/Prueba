using PruebaUWP.ViewModels;
using System;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace PruebaUWP
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Inicio_VM Inicio { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;

            var displayInformation = DisplayInformation.GetForCurrentView();
            var screenSize = new Size(displayInformation.ScreenWidthInRawPixels,
                                      displayInformation.ScreenHeightInRawPixels);
            this.Scroll.Height = screenSize.Height * 0.8;
            Inicio = new Inicio_VM();
        }

        private async void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await GetData();
        }

        public async Task GetData()
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () =>
            {
                await Inicio.Load();
                LstListado1.ItemsSource = Inicio.GetListado1;
                LstListado2.ItemsSource = Inicio.GetListado2;
                LstListado3.ItemsSource = Inicio.GetListado3;
                LstListado4.ItemsSource = Inicio.GetListado4;
            });
        }
    }
}