using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IDefault:
    IAfterScriptNavigation_lvl_1,
    IArtifactsNavigation_lvl_1,
    IBeforeScriptNavigation_lvl_1,
    ICacheNavigation_lvl_1,
    IImageNavigation_lvl_1,
    IInterruptibleNavigation_lvl_1,
    IRetryNavigation_lvl_1,
    IServicesNavigation_lvl_1,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1
 {}

public interface IDefaultNavigation_lvl_0{
    public IDefault Default();
}