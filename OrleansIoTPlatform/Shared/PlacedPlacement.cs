using System;
using System.Collections.Generic;
using System.Text;

using Orleans.Runtime;

namespace SwinIotFramework
{
    [Serializable]
    public class PlacedPlacement : PlacementStrategy
    {
        public static PlacedPlacement Singleton { get; } = new PlacedPlacement();
    }
}
