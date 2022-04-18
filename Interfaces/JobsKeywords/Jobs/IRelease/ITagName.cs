using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Release;

public interface ITagName:
    //going up 3 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    IResourceGroupNavigation,
    IBeforeScriptNavigation,
    IScriptNavigation,
    IAfterScriptNavigation,
    ITimeOutNavigation,
    ITriggerNavigation,
    IPagesNavigation,
    IWhenNavigation,
    //
    IDescriptionNavigation,
    IMilestonesNavigation
{}

public interface ITagNameNavigation{
    public ITagName TagName(string tagName);
}