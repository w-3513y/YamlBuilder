using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IStage:
    IScriptNavigation_lvl_2,
    IArtifactNavigation_lvl_2,
    IRulesNavigation_lvl_2
{}

public interface IStageNavigation_lvl_2{
    public IStage Stage(string stage);
}
