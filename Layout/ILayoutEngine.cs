﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tile.Net
{
    public interface ILayoutEngine
    {
        string Name { get; }

        IEnumerable<IWindowLocation> CalcLayout(int numWindows, int spaceWidth, int spaceHeight);

        void ShrinkMasterArea();
        void ExpandMasterArea();
        void ResetMasterArea();

        void IncrementNumInMaster();
        void DecrementNumInMaster();
    }
}
