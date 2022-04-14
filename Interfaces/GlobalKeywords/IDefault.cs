using YamlBuilder.Interfaces.JobsKeywords;
using YamlBuilder.Interfaces.JobsKeywords.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.IImage;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

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