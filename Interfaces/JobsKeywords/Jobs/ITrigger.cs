using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface ITrigger:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface ITriggerNavigation{
    public ITrigger Trigger();
}