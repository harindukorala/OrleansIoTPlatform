using System;

using System.Threading.Tasks;
using Orleans;
using Orleans.Runtime;

namespace SwinIotFramework
{
    public interface IPlacementHolder : IGrainWithGuidKey
    {
        Task<SiloAddress> GetSiloAddress(int interface_id);
        Task SetSiloAddress(int interface_id, SiloAddress address);
    }
}
