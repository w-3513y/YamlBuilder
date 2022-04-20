using YamlBuilder.Configuration;
using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

namespace YamlBuilder.Builder.Default.Cache;

public class Key : Cache, IDefault_Cache_Key
{
    public Key(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string name)
        => Utils.WriteFile(_fullPath, $"    key: {name}");

    public IDefault_Cache_Files Files(string[] files)
    {
        _serviceLocator.GetService<IDefault_Cache_Files>().Build(files);
        return _serviceLocator.GetService<IDefault_Cache_Files>();
    }
}

public class Files : Cache, IDefault_Cache_Files
{
    public Files(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string[] files)
    {
        Utils.WriteFile(_fullPath, $"      files:");
        foreach(var file in files)
        {
            Utils.WriteFile(_fullPath, $"        - {file}");
        }
    }

    public IDefault_Cache_Prefix Prefix(string name)
    {
        _serviceLocator.GetService<IDefault_Cache_Prefix>().Build(name);
        return _serviceLocator.GetService<IDefault_Cache_Prefix>();
    }
}

public class Prefix : Cache, IDefault_Cache_Prefix
{
    public Prefix(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string name)
    {
        Utils.WriteFile(_fullPath, $"      prefix: {name}");
    }
}

public class Paths : Cache, IDefault_Cache_Paths
{
    public Paths(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string[] directories)
    {
        Utils.WriteFile(_fullPath, $"    paths:");
        foreach(var directory in directories)
        {
            Utils.WriteFile(_fullPath, $"      - {directory}");
        }
    }
}

public class Policy : Cache, IDefault_Cache_Policy
{
    public Policy(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(GitCommand command)
        => Utils.WriteFile(_fullPath, $"    policy: {command}");
}

public class Untracked : Cache, IDefault_Cache_Untracked 
{
    public Untracked(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(bool untracked)
        => Utils.WriteFile(_fullPath, $"    untracked: {(untracked ? "true" : "false")}");
}

public class When : Cache, IDefault_Cache_When
{
    public When(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(JobGlobal when)
        => Utils.WriteFile(_fullPath, $"    when: {when}");
}