using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using SwinIotFramework;

namespace GrainInterfaces
{
    [PlacedPlacement]
    interface INode : Orleans.IGrainWithGuidKey
    {
        Task<INode[]> GetOutputs();
        Task SetOutputs(INode[] outputs);
        Task<string[]> GetOutputNames();
        Task<object> Process(object input);  
        Task KillUnlessLocatedAt(Orleans.Runtime.SiloAddress location);
    }
}
