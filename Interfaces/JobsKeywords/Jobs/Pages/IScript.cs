using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IJobs_Pages_Script:
    IJobs_Navigation_lvl_0,
    IJobs_When_Navigation_lvl_1,
    IJobs_Pages_Artifact_Navigation_lvl_2,
    IJobs_Pages_Rules_Navigation_lvl_2
{
    public void Build(string[] commands);
}

public interface IJobs_Pages_Script_Navigation_lvl_2{
    public IJobs_Pages_Script Script(string[] commands);
}