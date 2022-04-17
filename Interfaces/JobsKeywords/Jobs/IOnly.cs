using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IOnly:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IOnlyNavigation{
    public IOnly Only();
}