using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IPipelineVariables:
    IJobsNavigation_lvl_0,
    IPagesNavigation_lvl_1,
    IWhenNavigation_lvl_1
{}

public interface IPipelineVariablesNavigation_lvl_3{
    public IPipelineVariables PipelineVariables(bool isPipeline);
}