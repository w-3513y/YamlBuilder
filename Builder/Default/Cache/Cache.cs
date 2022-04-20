using YamlBuilder.Configuration;
using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

namespace YamlBuilder.Builder.Default.Cache;

public class Cache : Default, IDefault_Cache
{
    public Cache(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Cache_Key Key(string name)
    {
        _serviceLocator.GetService<IDefault_Cache_Key>().Build(name);
        return _serviceLocator.GetService<IDefault_Cache_Key>();
    }

    public IDefault_Cache_Paths Paths(string[] directories)
    {
        _serviceLocator.GetService<IDefault_Cache_Paths>().Build(directories);
        return _serviceLocator.GetService<IDefault_Cache_Paths>();
    }

    public IDefault_Cache_Policy Policy(GitCommand command)
    {
        _serviceLocator.GetService<IDefault_Cache_Policy>().Build(command);
        return _serviceLocator.GetService<IDefault_Cache_Policy>();
    }

    public IDefault_Cache_Untracked Untracked(bool untracked)
    {
        
        return _serviceLocator.GetService<IDefault_Cache_Untracked>();
    }

    public IDefault_Cache_When When(JobGlobal when)
    {
        _serviceLocator.GetService<IDefault_Cache_When>().Build(when);
        return _serviceLocator.GetService<IDefault_Cache_When>();
    }
}