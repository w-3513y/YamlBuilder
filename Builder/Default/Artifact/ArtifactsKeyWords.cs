using YamlBuilder.Configuration;
using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

namespace YamlBuilder.Builder.Default.Artifact;

public class Exclude : Artifacts, IDefault_Artifacts_Exclude
{
    public Exclude(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string file)
    {
        Utils.WriteFile(_fullPath, $"    exclude:");
        Utils.WriteFile(_fullPath, $"      - {file}");
    }
}

public class ExpireIn : Artifacts, IDefault_Artifacts_ExpireIn
{
    public ExpireIn(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string date)
        => Utils.WriteFile(_fullPath, $"    expire_in: {date}");
}

public class ExposeAs : Artifacts, IDefault_Artifacts_ExposeAs
{
    public ExposeAs(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string name)
        => Utils.WriteFile(_fullPath, $"    expose_as: {name}");
}

public class Name : Artifacts, IDefault_Artifacts_Name
{
    public Name(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string name)
        => Utils.WriteFile(_fullPath, $"    name: {name}");
}

public class Paths : Artifacts, IDefault_Artifacts_Paths
{
    public Paths(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string[] paths)
    {
        Utils.WriteFile(_fullPath, $"    paths:");
        foreach(var path in paths)
        {
            Utils.WriteFile(_fullPath, $"      - {path}");
        }
    }
}

public class Public : Artifacts, IDefault_Artifacts_Public
{
    public Public(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(bool publc)
        => Utils.WriteFile(_fullPath, $"    public: {(publc ? "true" : "false")}");
}

public class Untracked : Artifacts, IDefault_Artifacts_Untracked
{
    public Untracked(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(bool untracked) 
        => Utils.WriteFile(_fullPath, $"    untracked: {(untracked ? "true" : "false")}");
}

public class When : Artifacts, IDefault_Artifacts_When
{
    public When(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(JobGlobal when)
        => Utils.WriteFile(_fullPath, $"    when: {when}");
}