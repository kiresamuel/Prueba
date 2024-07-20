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
    public class Inicio_VM : BaseViewModel
    {
        private ApiService apiService;

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

        public List<GrupoModel> Listado3 { get; set; }
        private ObservableCollection<OpcionSeleccionada_VM> getListado3;
        public ObservableCollection<OpcionSeleccionada_VM> GetListado3
        {
            get { return this.getListado3; }
            set { this.SetValue(ref this.getListado3, value); }
        }

        public List<GrupoModel> Listado4 { get; set; }
        private ObservableCollection<OpcionSeleccionada_VM> getListado4;
        public ObservableCollection<OpcionSeleccionada_VM> GetListado4
        {
            get { return this.getListado4; }
            set { this.SetValue(ref this.getListado4, value); }
        }

        public Inicio_VM()
        {
            instance = this;
            this.apiService = new ApiService();
        }

        #region Singleton

        private static Inicio_VM instance;

        public static Inicio_VM GetInstance()
        {
            if (instance == null)
                return new Inicio_VM();

            return instance;
        }

        #endregion

        #region Metodos

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

            var response2= await this.apiService.GetData(url2);
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

            var url3 = Application.Current.Resources["UrlAPI_3"].ToString();

            var response3 = await this.apiService.GetData(url3);
            if (response3.Record == null)
            {
                var ms = new MessageDialog("Error extrayendo información de la lista 3.", "Error");
                await ms.ShowAsync();
                return false;
            }

            this.Listado3 = response3.Record.Response.Groups;
            var list3 = response3.Record.Response.Groups.Select(s => new OpcionSeleccionada_VM
            {
                Image_Large = s.Image_Large,
                Image_Medium = s.Image_Medium,
                Image_Small = s.Image_Small
            });
            this.GetListado3 = new ObservableCollection<OpcionSeleccionada_VM>(list3);

            var url4 = Application.Current.Resources["UrlAPI_4"].ToString();

            var response4 = await this.apiService.GetData(url4);
            if (response4.Record == null)
            {
                var ms = new MessageDialog("Error extrayendo información de la lista 4.", "Error");
                await ms.ShowAsync();
                return false;
            }

            this.Listado4 = response4.Record.Response.Groups;
            var list4 = response4.Record.Response.Groups.Select(s => new OpcionSeleccionada_VM
            {
                Image_Large = s.Image_Large,
                Image_Medium = s.Image_Medium,
                Image_Small = s.Image_Small
            });
            this.GetListado4 = new ObservableCollection<OpcionSeleccionada_VM>(list4);

            return true;
        }

        #endregion
    }
}
