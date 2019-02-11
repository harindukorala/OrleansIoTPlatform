using System.Threading.Tasks;

namespace OrleansIoTPlatform.GrainInterfaces
{
    public interface IMapper : Orleans.IGrainWithGuidKey
    {
        //Function declaration
        Task<AccelerationDataPerSec> MapAccelerationData(string document);
    }
}