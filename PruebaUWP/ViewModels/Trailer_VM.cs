using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace PruebaUWP.ViewModels
{
    public class Trailer_VM
    {
        #region Comandos

        public ICommand IrAtrasCommand
        {
            get { return new RelayCommand(IrAtras); }
        }

        #endregion

        #region Metodos

        private void IrAtras()
        {
            Frame fr = (Window.Current.Content as Frame);
            fr.Navigate(typeof(OpcionSeleccionada));
        }

        #endregion
    }
}