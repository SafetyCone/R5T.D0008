using System;
using System.Threading.Tasks;

using R5T.Magyar.Extensions;using R5T.T0064;


namespace R5T.D0008.Default
{[ServiceImplementationMarker]
    public class TimestampUtcDirectoryNameProvider : ITimestampUtcDirectoryNameProvider,IServiceImplementation
    {
        public Task<string> GetTimestampUtcDirectoryNameAsync(DateTime timestampUtc)
        {
            var timestampUtcDirectoryName = timestampUtc.ToYYYYMMDD_HHMMSS();

            return Task.FromResult(timestampUtcDirectoryName);
        }
    }
}
