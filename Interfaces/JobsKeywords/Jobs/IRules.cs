using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IRules:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IRulesNavigation{
    public IRules Rules();
}