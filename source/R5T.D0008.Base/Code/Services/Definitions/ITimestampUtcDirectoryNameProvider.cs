using System;
using System.Threading.Tasks;


namespace R5T.D0008
{
    public interface ITimestampUtcDirectoryNameProvider
    {
        Task<string> GetTimestampUtcDirectoryNameAsync(DateTime timestampUtc);
    }
}
