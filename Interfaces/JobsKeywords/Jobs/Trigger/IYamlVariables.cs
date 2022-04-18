using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IYamlVariables:
    IJobsNavigation,
    //going up 2 level(s)
    IPagesNavigation,
    IWhenNavigation
{}

public interface IYamlVariablesNavigation{
    public IYamlVariables YamlVariables(bool isYaml);
}