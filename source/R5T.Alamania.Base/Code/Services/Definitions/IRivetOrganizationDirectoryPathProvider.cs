using System;

using R5T.T0064;


namespace R5T.Alamania
{
    [ServiceDefinitionMarker]
    public interface IRivetOrganizationDirectoryPathProvider : IServiceDefinition
    {
        string GetRivetOrganizationDirectoryPath();
    }
}
