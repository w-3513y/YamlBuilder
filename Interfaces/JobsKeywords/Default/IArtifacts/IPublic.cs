using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.IArtifacts;

public interface IPublic:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
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
    IUntrackedNavigation,
    IWhenNavigation
{}

public interface IPublicNavigation{
    public IPublic Public(bool publ);
}
