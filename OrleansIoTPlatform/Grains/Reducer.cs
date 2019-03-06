using OrleansIoTPlatform.GrainInterfaces;
using System.Threading.Tasks;

using SwinIotFramework;

namespace OrleansIoTPlatform.Grains
{
    [PlacedPlacement]
    public class Reducer : Orleans.Grain<AccelerationDataPerSec>, IReducer
    {
        AccelerationDataPerSec newState = new AccelerationDataPerSec();

        public Task<AccelerationDataPerSec> GetResults()
        {
            return Task.FromResult(newState);
        }

        public Task ReduceAccelerationData(AccelerationDataPerSec subResults)
        {
            newState.MergeAccelo(subResults);
            return Task.FromResult(true);
        }
    }
}