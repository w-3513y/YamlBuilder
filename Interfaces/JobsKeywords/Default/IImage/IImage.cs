
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.IImage;

public interface IImage:
    //going down 1 level(s)
    INameNavigation,
    IEntryPointNavigation
{}

public interface IImageShortSintax:
    //going up 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IJobsNavigation,
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

    public IImage Image();
    public IImageShortSintax Image(string image);
    
}