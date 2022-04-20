using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IJobs_Trigger_PipelineVariables:
    IJobs_Navigation_lvl_0,
    IJobs_Pages_Navigation_lvl_1,
    IJobs_When_Navigation_lvl_1
{
    public void Build(bool isPipeline);
}

public interface IJobs_Trigger_PipelineVariables_Navigation_lvl_3{
    public IJobs_Trigger_PipelineVariables PipelineVariables(bool isPipeline);
}