using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

public interface IDefault_Artifacts_ExpireIn:
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_Cache_Navigation_lvl_1,
    IDefault_Interruptible_Navigation_lvl_1,
    IDefault_Retry_Navigation_lvl_1,
    IDefault_Services_Navigation_lvl_1,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1
{
    public void Build(string date);
}

public interface IDefault_Artifacts_ExpireIn_Navigation_lvl_2{
    public IDefault_Artifacts_ExpireIn ExpireIn(string date);
}

/*
Use expire_in to specify how long job artifacts are stored before they expire and are deleted. The expire_in setting does not affect:
    Artifacts from the latest job, unless keeping the latest job artifacts is:
    Pipeline artifacts. You can’t specify an expiration date for pipeline artifacts. See When pipeline artifacts are deleted for more information.
*/