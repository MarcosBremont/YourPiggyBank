using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using YourPiggyBank.Models;
using YourPiggyBank.Views;
using YourPiggyBank.ViewModels;

namespace YourPiggyBank.Views
{
    public partial class GastosPage : ContentPage
    {
        GastosViewModel _viewModel;

        public GastosPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new GastosViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
            LlenarMenu();


        }

        public async Task LlenarMenu()
        {
            try
            {
                lsv_gastos.IsVisible = false;
                YourPiggyBank.Metodos.Metodos metodos = new YourPiggyBank.Metodos.Metodos();
                lsv_gastos.ItemsSource = null;
                var datos = await metodos.ObtenerMenu("S");
                lsv_gastos.ItemsSource = datos;
                lsv_gastos.IsVisible = true;

            }
            catch (Exception ex)
            {

            }
        }
    }
}
