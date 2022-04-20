using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Builder.Default.Services;

public class ServicesShortSyntax : Default, IDefault_ServicesShortSyntax
{
    public ServicesShortSyntax(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string[] commands)
    {
        Utils.WriteFile(_fullPath, "  services:");
        foreach(var command in commands)
        {
            Utils.WriteFile(_fullPath, $"    - {command}");
        }
    }
}

public class Services : Default, IDefault_Services
{
    public Services(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public new void Build()
        => Utils.WriteFile(_fullPath, "  services:");

    public IDefault_Services_Name Name(string serviceName)
    {
        _serviceLocator.GetService<IDefault_Services_Name>().Build(serviceName);
        return _serviceLocator.GetService<IDefault_Services_Name>();
    }
}