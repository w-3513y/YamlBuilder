using YamlBuilder.Configuration;
using YamlBuilder.Enums;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default.Artifact;

public class Artifacts : Default, IDefault_Artifacts
{
    public Artifacts(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public new void Build() => Utils.WriteFile(_fullPath, "  artifacts:");

    public IDefault_Artifacts_Exclude Exclude(string file)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Exclude>().Build(file);
        return _serviceLocator.GetService<IDefault_Artifacts_Exclude>();
    }

    public IDefault_Artifacts_ExpireIn ExpireIn(string date)
    {
        _serviceLocator.GetService<IDefault_Artifacts_ExpireIn>().Build(date);
        return _serviceLocator.GetService<IDefault_Artifacts_ExpireIn>();
    }

    public IDefault_Artifacts_ExposeAs ExposeAs(string name)
    {
        _serviceLocator.GetService<IDefault_Artifacts_ExposeAs>().Build(name);
        return _serviceLocator.GetService<IDefault_Artifacts_ExposeAs>();
    }

    public IDefault_Artifacts_Name Name(string name)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Name>().Build(name);
        return _serviceLocator.GetService<IDefault_Artifacts_Name>();
    }

    public IDefault_Artifacts_Paths Paths(string[] paths)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Paths>().Build(paths);
        return _serviceLocator.GetService<IDefault_Artifacts_Paths>();
    }

    public IDefault_Artifacts_Public Public(bool publc)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Public>().Build(publc);
        return _serviceLocator.GetService<IDefault_Artifacts_Public>();
    }

    public IDefault_Artifacts_Report Report()
    {
        _serviceLocator.GetService<IDefault_Artifacts_Report>().Build();
        return _serviceLocator.GetService<IDefault_Artifacts_Report>();
    }

    public IDefault_Artifacts_Untracked Untracked(bool untracked)
    {
        _serviceLocator.GetService<IDefault_Artifacts_Untracked>().Build(untracked);
        return _serviceLocator.GetService<IDefault_Artifacts_Untracked>();
    }

    public IDefault_Artifacts_When When(JobGlobal when)
    {
        _serviceLocator.GetService<IDefault_Artifacts_When>().Build(when);
        return _serviceLocator.GetService<IDefault_Artifacts_When>();
    }
}