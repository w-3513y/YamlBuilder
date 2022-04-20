using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface IJobs_Release_Milestones:
    IJobs_Navigation_lvl_0,
    IJobs_ResourceGroup_Navigation_lvl_1,
    IJobs_BeforeScript_Navigation_lvl_1,
    IJobs_Script_Navigation_lvl_1,
    IJobs_AfterScript_Navigation_lvl_1,
    IJobs_TimeOut_Navigation_lvl_1,
    IJobs_Trigger_Navigation_lvl_1,
    IJobs_Pages_Navigation_lvl_1,
    IJobs_When_Navigation_lvl_1
{
    public void Build(string milestones);
}

public interface IJobs_Release_Milestones_Navigation_lvl_2{
    public IJobs_Release_Milestones Milestones(string milestones);
}