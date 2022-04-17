using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface INeeds:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface INeedsNavigation{
    public INeeds Needs();
}