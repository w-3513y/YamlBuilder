using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;

public interface IUntracked:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation,
    //going up 2 level(s)
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    IPathsNavigation,
    IWhenNavigation,
    IPolicyNavigation,
    IKeyNavigation
{}

public interface IUntrackedNavigation{
    public IUntracked Untracked(bool publc);   
}