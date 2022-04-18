using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IPages:
    //going down 3 level(s) abouve
    IStageNavigation,
    IScriptNavigation,
    IArtifactNavigation,
    IRulesNavigation
{}

public interface IPagesNavigation_lvl_1{
    public IPages Pages();
}