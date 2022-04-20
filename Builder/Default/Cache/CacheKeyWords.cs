using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

namespace YamlBuilder.Builder.Default.Cache;

public class Key : Cache, IDefault_Cache_Key
{
    public Key(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Cache_Files Files(string[] files)
    {
        Utils.WriteFile(_fullPath, $"      files:");
        foreach(var file in files)
        {
            Utils.WriteFile(_fullPath, $"        - {file}");
        }
        return _serviceLocator.GetService<IDefault_Cache_Files>();
    }
}

public class Files : Cache, IDefault_Cache_Files
{
    public Files(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Cache_Prefix Prefix(string name)
    {
        Utils.WriteFile(_fullPath, $"      prefix: {name}");
        return _serviceLocator.GetService<IDefault_Cache_Prefix>();
    }
}

public class Prefix : Cache, IDefault_Cache_Prefix
{
    public Prefix(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Paths : Cache, IDefault_Cache_Paths
{
    public Paths(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Policy : Cache, IDefault_Cache_Policy
{
    public Policy(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}
public class Untracked : Cache, IDefault_Cache_Untracked 
{
    public Untracked(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}
public class When : Cache, IDefault_Cache_When
{
    public When(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}