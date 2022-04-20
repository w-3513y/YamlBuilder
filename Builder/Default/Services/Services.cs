using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Builder.Default.Services;

public class ServicesShortSyntax : Default, IDefault_ServicesShortSyntax
{
    public ServicesShortSyntax(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Services : Default, IDefault_Services
{
    public Services(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Services_Name Name(string serviceName)
    {
        Utils.WriteFile(_fullPath, $"    - name: {serviceName}");
        return _serviceLocator.GetService<IDefault_Services_Name>();
    }
}