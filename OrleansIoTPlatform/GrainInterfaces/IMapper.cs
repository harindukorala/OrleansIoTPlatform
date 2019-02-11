using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace OrleansIoTPlatform.GrainInterfaces
{
    public interface IMapper : Orleans.IGrainWithGuidKey
    {
        //Function declaration
        Task<string> SayHello(string greeting);
        Task<AccelerationDataPerSec> MapAccelo(string document);
    }
}