using System;
using System.Collections.Generic;
using YourPiggyBank.ViewModels;
using YourPiggyBank.Views;
using Xamarin.Forms;

namespace YourPiggyBank
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

