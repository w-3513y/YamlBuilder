using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords;

public interface IRetry:
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    //going up 1 level(s)
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation
{}


public interface IRetryNavigation{

    public IRetry Retry(RetryEnum retry);
    
}