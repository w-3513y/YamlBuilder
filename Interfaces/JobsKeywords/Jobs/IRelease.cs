using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IRelease:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IReleaseNavigation{
    public IRelease Release();
}