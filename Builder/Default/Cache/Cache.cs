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
        Utils.WriteFile(_fullPath, $"    key: {name}");
        return _serviceLocator.GetService<IDefault_Cache_Key>();
    }

    public IDefault_Cache_Paths Paths(string[] directories)
    {
        Utils.WriteFile(_fullPath, $"    paths:");
        foreach(var directory in directories)
        {
            Utils.WriteFile(_fullPath, $"      - {directory}");
        }
        return _serviceLocator.GetService<IDefault_Cache_Paths>();
    }

    public IDefault_Cache_Policy Policy(GitCommand command)
    {
        Utils.WriteFile(_fullPath, $"    policy: {command}");
        return _serviceLocator.GetService<IDefault_Cache_Policy>();
    }

    public IDefault_Cache_Untracked Untracked(bool untracked)
    {
        Utils.WriteFile(_fullPath, $"    untracked: {(untracked ? "true" : "false")}");
        return _serviceLocator.GetService<IDefault_Cache_Untracked>();
    }

    public IDefault_Cache_When When(JobGlobal when)
    {
        Utils.WriteFile(_fullPath, $"    when: {when}");
        return _serviceLocator.GetService<IDefault_Cache_When>();
    }
}