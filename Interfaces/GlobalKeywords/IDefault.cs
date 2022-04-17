using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.Default.IImage;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IDefault:
    //going down 1 level(s)
    IAfter_ScriptNavigation,
    IArtifactsNavigation,
    IBefore_ScriptNavigation,
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