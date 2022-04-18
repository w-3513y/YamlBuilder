using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IStrategy: 
    IJobsNavigation_lvl_0,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface IStrategyNavigation_lvl_2{
    public IStrategy Strategy(string file);
}