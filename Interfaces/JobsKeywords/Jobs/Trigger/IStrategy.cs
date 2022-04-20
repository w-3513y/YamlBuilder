using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IJobs_Trigger_Strategy: 
    IJobs_Navigation_lvl_0,
    IJobs_Pages_Navigation_lvl_1,
    IJobs_When_Navigation_lvl_1
{
    public void Build(string multiProjectPipeline);
}

public interface IJobs_Trigger_Strategy_Navigation_lvl_2{
    public IJobs_Trigger_Strategy Strategy(string multiProjectPipeline);
}