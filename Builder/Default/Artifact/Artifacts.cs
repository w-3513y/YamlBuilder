using YamlBuilder.Configuration;
using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default.Artifact;

public class Artifacts : Default, IDefault_Artifacts
{
    public Artifacts(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Artifacts_Exclude Exclude(string file)
    {
        Utils.WriteFile(_fullPath, $"    exclude:");
        Utils.WriteFile(_fullPath, $"      - {file}");
        return _serviceLocator.GetService<IDefault_Artifacts_Exclude>();
    }

    public IDefault_Artifacts_ExpireIn ExpireIn(string date)
    {
        Utils.WriteFile(_fullPath, $"    expire_in: {date}");
        return _serviceLocator.GetService<IDefault_Artifacts_ExpireIn>();
    }

    public IDefault_Artifacts_ExposeAs ExposeAs(string name)
    {
        Utils.WriteFile(_fullPath, $"    expose_as: {name}");
        return _serviceLocator.GetService<IDefault_Artifacts_ExposeAs>();
    }

    public IDefault_Artifacts_Name Name(string name)
    {
        Utils.WriteFile(_fullPath, $"    name: {name}");
        return _serviceLocator.GetService<IDefault_Artifacts_Name>();
    }

    public IDefault_Artifacts_Paths Paths(string[] paths)
    {
        Utils.WriteFile(_fullPath, $"    paths:");
        foreach(var path in paths)
        {
            Utils.WriteFile(_fullPath, $"      - {path}");
        }
        return _serviceLocator.GetService<IDefault_Artifacts_Paths>();
    }

    public IDefault_Artifacts_Public Public(bool publ)
    {
        Utils.WriteFile(_fullPath, $"    public: {(publ ? "true" : "false")}");
        return _serviceLocator.GetService<IDefault_Artifacts_Public>();
    }

    public IDefault_Artifacts_Report Report()
    {
        Utils.WriteFile(_fullPath, $"    reports:");
        return _serviceLocator.GetService<IDefault_Artifacts_Report>();
    }

    public IDefault_Artifacts_Untracked Untracked(bool untracked)
    {
        Utils.WriteFile(_fullPath, $"    untracked: {(untracked ? "true" : "false")}");
        return _serviceLocator.GetService<IDefault_Artifacts_Untracked>();
    }

    public IDefault_Artifacts_When When(JobGlobal when)
    {
        Utils.WriteFile(_fullPath, $"    when: {when}");
        return _serviceLocator.GetService<IDefault_Artifacts_When>();
    }
}