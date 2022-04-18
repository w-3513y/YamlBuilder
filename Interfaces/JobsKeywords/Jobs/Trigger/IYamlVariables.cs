using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IYamlVariables:
    IJobsNavigation_lvl_0,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface IYamlVariablesNavigation_lvl_3{
    public IYamlVariables YamlVariables(bool isYaml);
}