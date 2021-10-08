using System;
using System.Collections.Generic;
using System.Text;

namespace MyTetrisProj.Models
{
    class DifficultySet
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public int Multiplier { get; private set; }
    }
}
