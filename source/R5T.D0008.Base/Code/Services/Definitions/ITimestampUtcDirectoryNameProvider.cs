using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0008
{
    [ServiceDefinitionMarker]
    public interface ITimestampUtcDirectoryNameProvider : IServiceDefinition
    {
        Task<string> GetTimestampUtcDirectoryNameAsync(DateTime timestampUtc);
    }
}
