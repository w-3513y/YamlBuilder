using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords;

public interface IInterruptible:    
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    //going up 1 level(s)
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation
{}


public interface IInterruptibleNavigation{

    public IInterruptible Interruptible(bool interruptible);
    
}