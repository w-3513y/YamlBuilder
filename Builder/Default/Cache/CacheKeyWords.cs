using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

namespace YamlBuilder.Builder.Default.Cache;

public class Key : Cache, IDefault_Cache_Key
{
    public Key(string path) : base(path){}

    public IDefault_Cache_Files Files(string[] files)
    {
        Utils.WriteFile(_fullPath, $"      files:");
        foreach(var file in files)
        {
            Utils.WriteFile(_fullPath, $"        - {file}");
        }
        return Utils.InvokeObject<IDefault_Cache_Files>(_fullPath);
    }
}

public class Files : Cache, IDefault_Cache_Files
{
    public Files(string path) : base(path){}

    public IDefault_Cache_Prefix Prefix(string name)
    {
        Utils.WriteFile(_fullPath, $"      prefix: {name}");
        return Utils.InvokeObject<IDefault_Cache_Prefix>(_fullPath);
    }
}

public class Prefix : Cache, IDefault_Cache_Prefix
{
    public Prefix(string path) : base(path){}
}

public class Paths : Cache, IDefault_Cache_Paths
{
    public Paths(string path) : base(path){}
}

public class Policy : Cache, IDefault_Cache_Policy
{
    public Policy(string path) : base(path){}
}
public class Untracked : Cache, IDefault_Cache_Untracked 
{
    public Untracked(string path) : base(path){}
}
public class When : Cache, IDefault_Cache_When
{
    public When(string path) : base(path){}
}