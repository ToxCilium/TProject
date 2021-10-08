using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyTetrisProj.Models;
using MyTetrisProj.View;

namespace MyTetrisProj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void change_compli(object sender, System.EventArgs e)
        {

        }

        private async void Starto(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StPage());
        }
        private async void Setting(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettPage());
        }
    }
}
