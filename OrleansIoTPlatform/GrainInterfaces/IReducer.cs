using System.Threading.Tasks;

namespace OrleansIoTPlatform.GrainInterfaces
{
    public interface IReducer : Orleans.IGrainWithIntegerKey
    {
        Task ReduceAccelo(AccelerationDataPerSec subResults);
        Task<AccelerationDataPerSec> GetResultsAccelo();
    }
}