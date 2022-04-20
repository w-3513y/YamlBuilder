using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Secrets;

public interface IJobs_Secrets_Vault:
    IJobs_Navigation_lvl_0,
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
    IJobs_When_Navigation_lvl_1,
    IJobs_Secrets_File_Navigation_lvl_4,
    IJobs_Secrets_Secret_Navigation_lvl_2
{
    public void Build(string vault);
}

public interface IJobs_Secrets_Vault_Navigation_lvl_3{
    public IJobs_Secrets_Vault Vault(string vault);
}