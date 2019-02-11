using System.Threading.Tasks;

namespace OrleansIoTPlatform.GrainInterfaces
{
    public interface IReducer : Orleans.IGrainWithIntegerKey
    {
        Task ReduceAccelerationData(AccelerationDataPerSec subResults);
        Task<AccelerationDataPerSec> GetResults();
    }
}