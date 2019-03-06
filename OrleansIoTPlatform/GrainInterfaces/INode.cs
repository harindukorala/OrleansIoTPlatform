using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

namespace GrainInterfaces
{
    interface INode : Orleans.IGrainWithGuidKey
    {
        Task<INode[]> GetOutputs();
        Task SetOutputs(INode[] outputs);
        Task<string[]> GetOutputNames();
        Task<object> Process(object input);  
        Task KillUnlessLocatedAt(Orleans.Runtime.SiloAddress location);
    }
}
