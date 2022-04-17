using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;

public interface IPolicy:    
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    //going up 2 level(s)
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    IPathsNavigation,
    IWhenNavigation,
    IUntracked,
    IKeyNavigation
{}


public interface IPolicyNavigation{
    public IPolicy Policy(GitCommand command);   
}