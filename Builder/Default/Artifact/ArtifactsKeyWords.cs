using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

namespace YamlBuilder.Builder.Default.Artifact;

public class Exclude : Artifacts, IDefault_Artifacts_Exclude
{
    public Exclude(string path) : base(path){}
}

public class ExpireIn : Artifacts, IDefault_Artifacts_ExpireIn
{
    public ExpireIn(string path) : base(path){}
}

public class ExposeAs : Artifacts, IDefault_Artifacts_ExposeAs
{
    public ExposeAs(string path) : base(path){}
}

public class Name : Artifacts, IDefault_Artifacts_Name
{
    public Name(string path) : base(path){}
}

public class Paths : Artifacts, IDefault_Artifacts_Paths
{
    public Paths(string path) : base(path){}
}

public class Public : Artifacts, IDefault_Artifacts_Public
{
    public Public(string path) : base(path){}
}

public class Untracked : Artifacts, IDefault_Artifacts_Untracked
{
    public Untracked(string path) : base(path){}
}

public class When : Artifacts, IDefault_Artifacts_When
{
    public When(string path) : base(path){}
}