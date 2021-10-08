using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Platform;
using MyTetrisProj.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using System.Diagnostics;

namespace MyTetrisProj.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StPage : ContentPage
    {
        private IList<BoardCellModel> board;
        public StPage()
        {
            InitializeComponent();

            Debug.WriteLine("==============================> TetrisViewModel c'tor");

            // initialize view model data repository
            this.board = new List<BoardCellModel>();
            for (int row = 0; row < 19; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    BoardCellModel cell = new BoardCellModel(this, Color.Gray);
                    this.board.Add(cell);
                }
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    BoxView boxView = new BoxView();
                    boxView.BindingContext =
                        (BoardCellModel)board[j + i * 10];

                    boxView.SetBinding(
                        BoxView.BackgroundColorProperty,
                        new Binding("CellColor"));
                    this.TetrisGrid.Children.Add(boxView, j, i);

                }
            }
            }



        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () => await PopupNavigation.PushAsync(new PausePopUp()));
            return true;
        }
    }
}