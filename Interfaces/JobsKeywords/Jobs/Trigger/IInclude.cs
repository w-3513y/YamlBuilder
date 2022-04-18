using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IInclude: 
    IJobsNavigation_lvl_0,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1,
    IStrategyNavigation_lvl_2
{}

public interface IIncludeNavigation_lvl_2{
    public IInclude Include(string file);
}