using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IInclude: 
    //going up 3 level(s) abouve
    IJobsNavigation,
    //going up 1 level(s)
    IStrategyNavigation
{}

public interface IIncludeNavigation{
    public IInclude Include(string file);
}