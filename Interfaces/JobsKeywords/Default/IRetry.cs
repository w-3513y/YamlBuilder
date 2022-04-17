using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface IRetry:
    //going up 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation,
    //going up 1 level(s)
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation
{}


public interface IRetryNavigation{

    public IRetry Retry(Retry retry);
    
}