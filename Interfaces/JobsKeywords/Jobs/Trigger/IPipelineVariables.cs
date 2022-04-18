using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IPipelineVariables:
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface IPipelineVariablesNavigation{
    public IPipelineVariables PipelineVariables(bool isPipeline);
}