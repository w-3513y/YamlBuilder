using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IPages:
    //going down 3 level(s) abouve
    IStageNavigation,
    IScriptNavigation,
    IArtifactNavigation,
    IRulesNavigation
{}

public interface IPagesNavigation{
    public IPages Pages();
}