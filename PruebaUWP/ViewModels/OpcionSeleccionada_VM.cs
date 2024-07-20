using GalaSoft.MvvmLight.Command;
using PruebaUWP.Services;
using PruebaUWP.ViewModels;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PruebaUWP.Models
{
    public class OpcionSeleccionada_VM : GrupoModel
    {
        private ApiService apiService;

        public OpcionSeleccionada_VM()
        {
            this.apiService = new ApiService();
        }

        #region Comandos

        public ICommand VerCommand
        {
            get { return new RelayCommand(Ver); }
        }

        #endregion

        #region Metodos

        private void Ver()
        {
            MainViewModel.GetInstance().DatosPeliculaVM = new DatosPelicula_VM(this);
            Frame fr = (Window.Current.Content as Frame);
            fr.Navigate(typeof(OpcionSeleccionada));
        }

        #endregion
    }
}