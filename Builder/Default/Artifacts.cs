using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default;

public class Artifacts : Default, IDefault_Artifacts
{
    public Artifacts(string path) : base(path){}

    public IDefault_Artifacts_Exclude Exclude(string file)
    {
        throw new NotImplementedException();
    }

    public IDefault_Artifacts_ExpireIn ExpireIn(string date)
    {
        throw new NotImplementedException();
    }

    public IDefault_Artifacts_ExposeAs ExposeAs(string name)
    {
        throw new NotImplementedException();
    }

    public IDefault_Artifacts_Name Name(string name)
    {
        throw new NotImplementedException();
    }

    public IDefault_Artifacts_Paths Paths(string[] paths)
    {
        throw new NotImplementedException();
    }

    public IDefault_Artifacts_Public Public(bool publ)
    {
        throw new NotImplementedException();
    }

    public IDefault_Artifacts_Report_Report Report()
    {
        throw new NotImplementedException();
    }

    public IDefault_Artifacts_Untracked Untracked(bool untracked)
    {
        throw new NotImplementedException();
    }

    public IDefault_Artifacts_When When(JobGlobal when)
    {
        throw new NotImplementedException();
    }
}