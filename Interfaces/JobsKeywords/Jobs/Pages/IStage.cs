using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IJobs_Pages_Stage:
    IJobs_Pages_Script_Navigation_lvl_2,
    IJobs_Pages_Artifact_Navigation_lvl_2,
    IJobs_Pages_Rules_Navigation_lvl_2
{
    public void Build(string stage);
}

public interface IJobs_Pages_Stage_Navigation_lvl_2{
    public IJobs_Pages_Stage Stage(string stage);
}
