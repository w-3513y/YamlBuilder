
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Image;

public interface IImage:
    INameNavigation_lvl_2,
    IEntryPointNavigation_lvl_2
{}

public interface IImageShortSintax:
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    IAfterScriptNavigation_lvl_1,
    IArtifactsNavigation_lvl_1,
    IBeforeScriptNavigation_lvl_1,
    ICacheNavigation_lvl_1,
    IInterruptibleNavigation_lvl_1,
    IRetryNavigation_lvl_1,
    IServicesNavigation_lvl_1,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1
{}

public interface IImageNavigation_lvl_1{

    public IImage Image();
    public IImageShortSintax Image(string image);
    
}