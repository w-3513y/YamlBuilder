using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Inherit;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Needs;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Variables;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IEnvironment;

public interface IJobs_Environment:
    IJobs_Environment_Name_Navigation_lvl_2
{}
public interface IJobs_EnvironmentShortSintax:
    IJobs_Navigation_lvl_0,
    IJobs_Extends_Navigation_lvl_1,
    IJobs_Inherit_Navigation_lvl_1,
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
{}

public interface IJobs_Environment_Navigation_lvl_1{
    public IJobs_Environment Environment();
    public IJobs_EnvironmentShortSintax Environment(string environment);
}