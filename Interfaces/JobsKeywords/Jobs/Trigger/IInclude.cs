using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IInclude: 
    //going up 3 level(s) abouve
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1,
    //going up 1 level(s)
    IStrategyNavigation
{}

public interface IIncludeNavigation{
    public IInclude Include(string file);
}