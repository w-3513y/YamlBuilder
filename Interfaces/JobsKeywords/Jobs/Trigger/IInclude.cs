using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IInclude: 
    //going up 3 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    IPagesNavigation,
    IWhenNavigation,
    //going up 1 level(s)
    IStrategyNavigation
{}

public interface IIncludeNavigation{
    public IInclude Include(string file);
}