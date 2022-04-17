using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Needs;

public interface IJob:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //recursion
    IJobNavigation,
    IArtifactsNavigation
{}

public interface IJobNavigation{
    public IJob Job(string job);
}