using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyTetrisProj.Models
{
    public interface ITetris : INotifyPropertyChanged
    {
        // general properties
        int NumRows { get; }
        int NumColumns { get; }

        // game commands
        void Start();
        void Stop();
        void Pause();
        void Continue();
        void Clear();

        // score management
        int Level { get; }
        int Lines { get; }
        int Score { get; }
    }
}
