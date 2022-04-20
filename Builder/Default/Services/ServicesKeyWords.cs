using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Builder.Default.Services;


public class Name : Services, IDefault_Services_Name
{
    public Name(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string serviceName)
        => Utils.WriteFile(_fullPath, $"    - name: {serviceName}");

    public IDefault_Services_Alias Alias(string alias)
    {
        _serviceLocator.GetService<IDefault_Services_Alias>().Build(alias);
        return _serviceLocator.GetService<IDefault_Services_Alias>();
    }

    public IDefault_Services_EntryPoint Entrypoint(string entrypoint)
    {
        Utils.WriteFile(_fullPath, $"    entrypoint: [{entrypoint}]");
        return _serviceLocator.GetService<IDefault_Services_EntryPoint>();
    }
}

public class Alias : Name, IDefault_Services_Alias
{
    public Alias(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public new void Build(string alias)
        => Utils.WriteFile(_fullPath, $"    alias: {alias}");
}

public class Entrypoint : Alias, IDefault_Services_EntryPoint
{
    public Entrypoint(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Services_Command Command(string command)
    {
        _serviceLocator.GetService<IDefault_Services_Command>().Build(command);
        return _serviceLocator.GetService<IDefault_Services_Command>();
    }
}

public class Command : Services, IDefault_Services_Command
{
    public Command(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string command)
        => Utils.WriteFile(_fullPath, $"    command: [{command}]");
}