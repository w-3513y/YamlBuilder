using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Needs;

public interface IArtifacts:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //recursion
    IJobNavigation
{}

public interface IArtifactsNavigation{
    public IArtifacts Artifacts(bool yes);
}