using YamlBuilder.Configuration;

namespace YamlBuilder.Builder;

public abstract class BaseBuilder
{
    internal readonly string _fullPath;
    internal readonly IServiceLocator _serviceLocator;

    protected BaseBuilder(string fullPath, IServiceLocator serviceLocator)
    {
        _fullPath = fullPath;
        _serviceLocator = serviceLocator;
    }
}