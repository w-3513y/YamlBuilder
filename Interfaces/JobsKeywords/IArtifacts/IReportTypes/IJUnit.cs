using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts.IRepostTypes;

public interface IJUnit:
    //navigation 5 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    //going up 3 level(s)
    IBefore_ScriptNavigation,
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 2 level(s)
    IExpireInNavigation,
    IReportNavigation,
    //going up 1 level(s)
    ISastNavigation,
    ISecretSedentionNavigation,
    ITerraformNavigation
{}

public interface IJUnitNavigation{
    public IJUnit JUnit(string report);
}