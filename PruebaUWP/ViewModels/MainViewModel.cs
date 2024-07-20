using GalaSoft.MvvmLight.Command;
using PruebaUWP.Models;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace PruebaUWP.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public UsuarioModel Session { get; set; }

        public MainViewModel()
        {
            instance = this;
        }

        #region Singleton

        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }

        #endregion

        public Inicio_VM Inicio { get; set; }
        public OpcionSeleccionada_VM OpcionSeleccionadaVM { get; set; }
        public DatosPelicula_VM DatosPeliculaVM { get; set; }
        public Trailer_VM TrailerVM { get; set; }
    }
}