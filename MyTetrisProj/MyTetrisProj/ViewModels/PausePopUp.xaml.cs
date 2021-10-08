using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTetrisProj.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PausePopUp : PopupPage
    {
        public PausePopUp()
        {
            InitializeComponent();
        }
        private async void Cont(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync(true);
        }
        private async void TMM(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync(true);
            await Navigation.PopModalAsync();
        }
    }
}