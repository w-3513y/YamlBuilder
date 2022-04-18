using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IPipelineVariables:
    IJobsNavigation
{}

public interface IPipelineVariablesNavigation{
    public IPipelineVariables PipelineVariables(bool isPipeline);
}