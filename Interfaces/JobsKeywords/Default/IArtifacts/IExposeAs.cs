using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.IArtifacts;

public interface IExposeAs:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    //going up 2 level(s)
    IBefore_ScriptNavigation,
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    IPathsNavigation,
    IExpireInNavigation,
    IExcludeNavigation,
    IExposeAsNavigation,
    IReportNavigation
{}

public interface IExposeAsNavigation{
    public IExposeAs ExposeAs(string name);
    
}

//Use the artifacts:expose_as keyword to expose job artifacts in the merge request UI.