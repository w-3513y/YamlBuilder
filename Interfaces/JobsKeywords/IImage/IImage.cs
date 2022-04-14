
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords;
using YamlBuilder.Interfaces.JobsKeywords.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.IImage;

public interface IImage:
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    //going up 1 level(s)
    IAfter_ScriptNavigation,
    IArtifactsNavigation,
    IBefore_ScriptNavigation,
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation
{}

public interface IImageNavigation{

    public IImage Image(string image);
    
}