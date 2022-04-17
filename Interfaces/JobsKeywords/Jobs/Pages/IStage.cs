using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IStage:
    //going up 1 level(s)
    IScriptNavigation,
    IArtifactNavigation,
    IRulesNavigation
{}

public interface IStageNavigation{
    public IStage Stage(string stage);
}
