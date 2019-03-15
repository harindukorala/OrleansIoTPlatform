using System;

using System.Threading.Tasks;
using Orleans;
using Orleans.Runtime;

namespace SwinIotFramework
{
    public interface IPlacementHolder : IGrainWithGuidKey
    {
        Task<SiloAddress> GetSiloAddress(int interface_id);
        void SetSiloAddress(string resource, SiloAddress);
        void SetLocation(int interface_id, string resource);
    }
}
