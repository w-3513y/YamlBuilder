using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IJobs_Pages:
    IJobs_Pages_Stage_Navigation_lvl_2,
    IJobs_Pages_Script_Navigation_lvl_2,
    IJobs_Pages_Artifact_Navigation_lvl_2,
    IJobs_Pages_Rules_Navigation_lvl_2
{}

public interface IJobs_Pages_Navigation_lvl_1{
    public IJobs_Pages Pages();
}