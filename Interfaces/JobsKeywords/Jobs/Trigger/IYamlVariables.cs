using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IYamlVariables:
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface IYamlVariablesNavigation{
    public IYamlVariables YamlVariables(bool isYaml);
}