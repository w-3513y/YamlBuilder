using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts.Default.IRepostTypes;

public interface IDotEnv:
    //going up 5 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation,
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
    IJUnitNavigation,
    ISastNavigation,
    ISecretSedentionNavigation,
    ITerraformNavigation
{}

public interface IDotEnvNavigation{
    public IDotEnv DotEnv(string report);
}