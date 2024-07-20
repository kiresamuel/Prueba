using GalaSoft.MvvmLight.Command;
using PruebaUWP.Models;
using PruebaUWP.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PruebaUWP.ViewModels
{
    public class DatosPelicula_VM : BaseViewModel
    {
        private ApiService apiService;

        private GrupoModel seleccion;
        public GrupoModel Seleccion
        {
            get { return this.seleccion; }
            set { this.SetValue(ref this.seleccion, value); }
        }

        private GrupoPeliculaModel pelicula;
        public GrupoPeliculaModel Pelicula
        {
            get { return this.pelicula; }
            set { this.SetValue(ref this.pelicula, value); }
        }

        public List<GrupoModel> Listado1 { get; set; }
        private ObservableCollection<OpcionSeleccionada_VM> getListado1;
        public ObservableCollection<OpcionSeleccionada_VM> GetListado1
        {
            get { return this.getListado1; }
            set { this.SetValue(ref this.getListado1, value); }
        }

        public List<GrupoModel> Listado2 { get; set; }
        private ObservableCollection<OpcionSeleccionada_VM> getListado2;
        public ObservableCollection<OpcionSeleccionada_VM> GetListado2
        {
            get { return this.getListado2; }
            set { this.SetValue(ref this.getListado2, value); }
        }

        public DatosPelicula_VM()
        {
            instance = this;
            this.apiService = new ApiService();
        }

        public DatosPelicula_VM(OpcionSeleccionada_VM item_VM)
        {
            instance = this;
            this.apiService = new ApiService();
            this.Seleccion = item_VM;
        }

        #region Singleton
        private static DatosPelicula_VM instance;

        public static DatosPelicula_VM GetInstance()
        {
            if (instance == null)
            {
                return new DatosPelicula_VM();
            }

            return instance;
        }
        #endregion

        #region Comandos

        public ICommand IrInicioCommand
        {
            get { return new RelayCommand(IrInicio); }
        }

        public ICommand VerTrailerCommand
        {
            get { return new RelayCommand(VerTrailer); }
        }

        #endregion

        #region Metodos

        private void IrInicio()
        {
            Frame fr = (Window.Current.Content as Frame);
            fr.Navigate(typeof(MainPage));
        }

        private void VerTrailer()
        {
            MainViewModel.GetInstance().TrailerVM = new Trailer_VM();
            Frame fr = (Window.Current.Content as Frame);
            fr.Navigate(typeof(Video));
        }

        public async Task<bool> Load()
        {
            var connection = await this.apiService.CheckConnection();
            if (!connection.ExecutionOK)
            {
                var ms = new MessageDialog(connection.Message, "Error");
                await ms.ShowAsync();
                return false;
            }

            var url1 = Application.Current.Resources["UrlAPI_1"].ToString();

            var response1 = await this.apiService.GetData(url1);
            if (response1.Record == null)
            {
                var ms = new MessageDialog("Error extrayendo información de la lista 1.", "Error");
                await ms.ShowAsync();
                return false;
            }

            this.Listado1 = response1.Record.Response.Groups;
            var list1 = response1.Record.Response.Groups.Select(s => new OpcionSeleccionada_VM
            {
                Image_Large = s.Image_Large,
                Image_Medium = s.Image_Medium,
                Image_Small = s.Image_Small
            });
            this.GetListado1 = new ObservableCollection<OpcionSeleccionada_VM>(list1);

            var url2 = Application.Current.Resources["UrlAPI_2"].ToString();

            var response2 = await this.apiService.GetData(url2);
            if (response2.Record == null)
            {
                var ms = new MessageDialog("Error extrayendo información de la lista 2.", "Error");
                await ms.ShowAsync();
                return false;
            }

            this.Listado2 = response2.Record.Response.Groups;
            var list2 = response2.Record.Response.Groups.Select(s => new OpcionSeleccionada_VM
            {
                Image_Large = s.Image_Large,
                Image_Medium = s.Image_Medium,
                Image_Small = s.Image_Small
            });
            this.GetListado2 = new ObservableCollection<OpcionSeleccionada_VM>(list2);

            var url5 = Application.Current.Resources["UrlAPI_5"].ToString();

            var response5 = await this.apiService.GetMovieData(url5);
            if (response5.Record == null)
            {
                var ms = new MessageDialog("Error extrayendo información de la Película.", "Error");
                await ms.ShowAsync();
                return false;
            }
            this.Pelicula = response5.Record.Response.Group;

            return true;
        }

        #endregion
    }
}