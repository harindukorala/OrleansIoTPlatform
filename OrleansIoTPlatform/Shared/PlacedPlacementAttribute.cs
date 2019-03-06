using System;
using System.Collections.Generic;
using System.Text;

using Orleans.Placement;

namespace SwinIotFramework
{
    public class PlacedPlacementAttribute : PlacementAttribute
    {
        public PlacedPlacementAttribute() :
            base(PlacedPlacement.Singleton)
        {

        }
    }
}
