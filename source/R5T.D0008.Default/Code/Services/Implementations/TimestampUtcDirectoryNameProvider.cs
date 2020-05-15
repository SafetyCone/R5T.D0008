using System;
using System.Threading.Tasks;

using R5T.Magyar.Extensions;


namespace R5T.D0008.Default
{
    public class TimestampUtcDirectoryNameProvider : ITimestampUtcDirectoryNameProvider
    {
        public Task<string> GetTimestampUtcDirectoryName(DateTime timestampUtc)
        {
            var timestampUtcDirectoryName = timestampUtc.ToYYYYMMDD_HHMMSS();

            return Task.FromResult(timestampUtcDirectoryName);
        }
    }
}
