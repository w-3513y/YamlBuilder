using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IStrategy: 
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
{}

public interface IStrategyNavigation{
    public IStrategy Strategy(string file);
}