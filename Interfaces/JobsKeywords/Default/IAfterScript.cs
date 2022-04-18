using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface IAfterScript: 
    //going up 3 level(s) abouve
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    //going up 1 level(s)
    IArtifactsNavigation_lvl_1,
    IBeforeScriptNavigation_lvl_1,
    ICacheNavigation_lvl_1,
    IInterruptibleNavigation_lvl_1,
    IRetryNavigation_lvl_1,
    IServicesNavigation_lvl_1,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1
{}

public interface IAfterScriptNavigation_lvl_1{
    public IAfterScript AfterScript(string commands);
}


    /*Use after_script to define an array of commands that run after each job, including failed jobs.
     Keyword type: Job keyword. You can use it only as part of a job or in the default section.
     Possible inputs: An array including:
     
     Single line commands.
     Long commands split over multiple lines.
     YAML anchors.*/
