﻿using System.ComponentModel;
using Xamarin.Forms;
using YourPiggyBank.ViewModels;

namespace YourPiggyBank.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
