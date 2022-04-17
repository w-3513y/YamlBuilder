using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface IReleasedAt:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IReleasedAtNavigation{
    public IReleasedAt ReleasedAt(string releaseAt);
}