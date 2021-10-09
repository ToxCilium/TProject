using System;
using System.Collections.Generic;
using System.Text;
using MyTetrisProj.View;
using Xamarin.Forms;
using GalaSoft.MvvmLight;

namespace MyTetrisProj.ViewModels
{
    public class BoardCellModel : ViewModelBase
    {
        private StPage model;
        private Color cellColor;
        private Color gray;

        public BoardCellModel( Color cellColor)
        {
            this.cellColor = cellColor;
        }



        public Color CellColor
        {
            get
            {
                return this.cellColor;
            }

            set
            {
                if (this.cellColor != value)
                {
                    this.cellColor = value;
                    this.RaisePropertyChanged(() => CellColor);
                }
            }
        }
    }
}
