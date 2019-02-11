using Microsoft.Extensions.Logging;
using Orleans.Concurrency;
using OrleansIoTPlatform.GrainInterfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrleansIoTPlatform.Grains
{
    [StatelessWorker]
    public class Mapper : Orleans.Grain, IMapper
    {
        //Implementation code 
        private readonly ILogger logger;

        public Mapper(ILogger<Mapper> logger)
        {
            this.logger = logger;
        }

        public Task<AccelerationDataPerSec> MapAccelerationData(string document)
        {
            string[] splittedData = document.Split(',');
            double x, y, z;
            x = double.Parse(splittedData[1]);
            y = double.Parse(splittedData[2]);
            z = double.Parse(splittedData[3]);

            //Calculate the Average for accelerometr X,Y,Z per one timestamp
            double average = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

            List<AccelerationData> accelo = new List<AccelerationData>
            {
                new AccelerationData(splittedData[0], 1, average)
            };

            logger.LogInformation(average.ToString());

            var result = new AccelerationDataPerSec(accelo);
            return Task.FromResult(result);
        }
    }
}