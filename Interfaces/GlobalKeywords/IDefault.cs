using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IDefault:
    //going down 1 level(s)
    IAfterScriptNavigation,
    IArtifactsNavigation,
    IBeforeScriptNavigation,
    ICacheNavigation,
    IImageNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation
 {}

public interface IDefaultNavigation{
    public IDefault Default();
}