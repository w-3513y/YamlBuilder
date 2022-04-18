using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IPages:
    IStageNavigation_lvl_2,
    IScriptNavigation_lvl_2,
    IArtifactNavigation_lvl_2,
    IRulesNavigation_lvl_2
{}

public interface IPagesNavigation_lvl_1{
    public IPages Pages();
}