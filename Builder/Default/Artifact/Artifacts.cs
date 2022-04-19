using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default.Artifact;

public class Artifacts : Default, IDefault_Artifacts
{
    public Artifacts(string path) : base(path){}

    public IDefault_Artifacts_Exclude Exclude(string file)
    {
        Utils.WriteFile(_fullPath, $"    exclude:");
        Utils.WriteFile(_fullPath, $"      - {file}");
        return Utils.InvokeObject<IDefault_Artifacts_Exclude>(_fullPath);
    }

    public IDefault_Artifacts_ExpireIn ExpireIn(string date)
    {
        Utils.WriteFile(_fullPath, $"    expire_in: {date}");
        return Utils.InvokeObject<IDefault_Artifacts_ExpireIn>(_fullPath);
    }

    public IDefault_Artifacts_ExposeAs ExposeAs(string name)
    {
        Utils.WriteFile(_fullPath, $"    expose_as: {name}");
        return Utils.InvokeObject<IDefault_Artifacts_ExposeAs>(_fullPath);
    }

    public IDefault_Artifacts_Name Name(string name)
    {
        Utils.WriteFile(_fullPath, $"    name: {name}");
        return Utils.InvokeObject<IDefault_Artifacts_Name>(_fullPath);
    }

    public IDefault_Artifacts_Paths Paths(string[] paths)
    {
        Utils.WriteFile(_fullPath, $"    paths:");
        foreach(var path in paths)
        {
            Utils.WriteFile(_fullPath, $"      - {path}");
        }
        return Utils.InvokeObject<IDefault_Artifacts_Paths>(_fullPath);
    }

    public IDefault_Artifacts_Public Public(bool publ)
    {
        Utils.WriteFile(_fullPath, $"    public: {(publ ? "true" : "false")}");
        return Utils.InvokeObject<IDefault_Artifacts_Public>(_fullPath);
    }

    public IDefault_Artifacts_Report Report()
    {
        Utils.WriteFile(_fullPath, $"    reports:");
        return Utils.InvokeObject<IDefault_Artifacts_Report>(_fullPath);
    }

    public IDefault_Artifacts_Untracked Untracked(bool untracked)
    {
        Utils.WriteFile(_fullPath, $"    untracked: {(untracked ? "true" : "false")}");
        return Utils.InvokeObject<IDefault_Artifacts_Untracked>(_fullPath);
    }

    public IDefault_Artifacts_When When(JobGlobal when)
    {
        Utils.WriteFile(_fullPath, $"    when: {when}");
        return Utils.InvokeObject<IDefault_Artifacts_When>(_fullPath);
    }
}