using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IPipelineVariables:
    IJobsNavigation,
    //going up 2 level(s)
    IPagesNavigation,
    IWhenNavigation
{}

public interface IPipelineVariablesNavigation{
    public IPipelineVariables PipelineVariables(bool isPipeline);
}