using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.IArtifacts;

public interface IExpireIn:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    //going up 2 level(s)
    IBefore_ScriptNavigation,
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation
{}

public interface IExpireInNavigation{
    public IExpireIn ExpireIn(string date);
}

/*
Use expire_in to specify how long job artifacts are stored before they expire and are deleted. The expire_in setting does not affect:
    Artifacts from the latest job, unless keeping the latest job artifacts is:
    Pipeline artifacts. You can’t specify an expiration date for pipeline artifacts. See When pipeline artifacts are deleted for more information.
*/