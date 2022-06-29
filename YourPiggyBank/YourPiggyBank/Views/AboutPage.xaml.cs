using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YourPiggyBank.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            ImgPesoDominicano.GestureRecognizers.Add(
               new TapGestureRecognizer()
               {
                   Command = new Command(async () =>
                   {
                       ImgPiggyB.IsAnimationPlaying = true;

                   }),
                   NumberOfTapsRequired = 1

               }
             );

            ImgPesoDominicano5.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );

            ImgPesoDominicano.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );

            ImgPesoDominicano5.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );

            ImgPesoDominicano10.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );

            ImgPesoDominicano25.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );

            //Billetes


            ImgBillete100.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );

            ImgBillete200.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );

            ImgBillete500.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );

            ImgBillete1000.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );

            ImgBillete2000.GestureRecognizers.Add(
             new TapGestureRecognizer()
             {
                 Command = new Command(async () =>
                 {
                     ImgPiggyB.IsAnimationPlaying = true;

                 }),
                 NumberOfTapsRequired = 1

             }
           );


        }
    }
}
