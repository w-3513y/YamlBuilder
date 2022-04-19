using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

namespace YamlBuilder.Builder.Default.Artifact;

public class Exclude : Artifacts, IDefault_Artifacts_Exclude
{
    public Exclude(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class ExpireIn : Artifacts, IDefault_Artifacts_ExpireIn
{
    public ExpireIn(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class ExposeAs : Artifacts, IDefault_Artifacts_ExposeAs
{
    public ExposeAs(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Name : Artifacts, IDefault_Artifacts_Name
{
    public Name(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Paths : Artifacts, IDefault_Artifacts_Paths
{
    public Paths(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Public : Artifacts, IDefault_Artifacts_Public
{
    public Public(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Untracked : Artifacts, IDefault_Artifacts_Untracked
{
    public Untracked(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class When : Artifacts, IDefault_Artifacts_When
{
    public When(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}