using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts;

public interface IUntracked:
    //navigation 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    //going up 2 level(s)
    IBefore_ScriptNavigation,
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    INameNavigation,
    IPathsNavigation,
    IExpireInNavigation,
    IExcludeNavigation,
    IExposeAsNavigation,
    IReportNavigation,
    IWhenNavigation
{}


public interface IUntrackedNavigation{
    public IUntracked Untracked(bool untracked);
}