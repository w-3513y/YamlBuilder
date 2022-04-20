using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Needs;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Variables;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Inherit;

public interface IJobs_Inherit_Default: 
    IJobs_Navigation_lvl_0,
    IJobs_Needs_Navigation_lvl_1,
    IJobs_Variables_Navigation_lvl_1,
    IJobs_Rules_Navigation_lvl_1,
    IJobs_Tags_Navigation_lvl_1,
    IJobs_Retry_Navigation_lvl_1,
    IJobs_AllowFailure_Navigation_lvl_1,
    IJobs_Artifacts_Navigation_lvl_1,
    IJobs_Cache_Navigation_lvl_1,
    IJobs_Coverage_Navigation_lvl_1,
    IJobs_Secrets_Navigation_lvl_1,
    IJobs_Dependencies_Navigation_lvl_1,
    IJobs_Interruptible_Navigation_lvl_1,
    IJobs_Parallel_Navigation_lvl_1,
    IJobs_Release_Navigation_lvl_1,
    IJobs_ResourceGroup_Navigation_lvl_1,
    IJobs_BeforeScript_Navigation_lvl_1,
    IJobs_Script_Navigation_lvl_1,
    IJobs_AfterScript_Navigation_lvl_1,
    IJobs_TimeOut_Navigation_lvl_1,
    IJobs_Trigger_Navigation_lvl_1,
    IJobs_Pages_Navigation_lvl_1,
    IJobs_When_Navigation_lvl_1
{
    public void Build(string[] commands);
    public void Build(bool deflt);
}

public interface IJobs_Inherit_Default_Navigation_lvl_2{
    public IJobs_Inherit_Default Default(string[] commands);
    public IJobs_Inherit_Default Default(bool deftl);
}