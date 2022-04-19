using YamlBuilder.Interfaces.GitLab;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IDefault:
    IDefault_AfterScript_Navigation_lvl_1,
    IIDefault_Artifacts_Artifacts_Navigation_lvl_1,
    IDefault_BeforeScript_Navigation_lvl_1,
    IDefault_Cache_Navigation_lvl_1,
    IImageNavigation_lvl_1,
    IDefault_Interruptible_Navigation_lvl_1,
    IDefault_Retry_Navigation_lvl_1,
    IDefault_Services_Navigation_lvl_1,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1
 {}

public interface IDefaultNavigation_lvl_0{
    public IDefault Default();
}