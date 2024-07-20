using PruebaUWP.ViewModels;
using System;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PruebaUWP
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class OpcionSeleccionada : Page
    {
        public DatosPelicula_VM DatosPeliculas { get; set; }

        public OpcionSeleccionada()
        {
            this.InitializeComponent();
            this.Loaded += OpcionSeleccionada_Loaded;

            var displayInformation = DisplayInformation.GetForCurrentView();
            var screenSize = new Size(displayInformation.ScreenWidthInRawPixels,
                                      displayInformation.ScreenHeightInRawPixels);
            this.Scroll.Height = screenSize.Height * 0.8;
            DatosPeliculas = new DatosPelicula_VM();
            DataContext = DatosPeliculas;
        }

        private async void OpcionSeleccionada_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await GetData();
        }

        public async Task GetData()
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () =>
            {
                await DatosPeliculas.Load();
                LstListado1.ItemsSource = DatosPeliculas.GetListado1;
                LstListado2.ItemsSource = DatosPeliculas.GetListado2;
                ImgBackgroud.Source = new BitmapImage(new Uri(DatosPeliculas.Pelicula.Common.Image_Background));
                TxtTitulo.Text = DatosPeliculas.Pelicula.Common.Title;
                TxtDesc.Text = DatosPeliculas.Pelicula.External.Gracenote.Description;
                TxtDatos1.Text = DatosPeliculas.Pelicula.External.Gracenote.Title + " |";   //TituloOriginal
                TxtDatos2.Text = DatosPeliculas.Pelicula.External.Gracenote.Genres[0] + ", " +
                    DatosPeliculas.Pelicula.External.Gracenote.Genres[1];                   //Generos
                TxtDatos3.Text = DatosPeliculas.Pelicula.External.Gracenote.Publishyear;    //Año
                TxtDatos4.Text = DatosPeliculas.Pelicula.External.Gracenote.Rating;         //Rating
                TxtDatos5.Text = DatosPeliculas.Pelicula.External.Gracenote.Duration;       //Duración
            });
        }
    }
}
