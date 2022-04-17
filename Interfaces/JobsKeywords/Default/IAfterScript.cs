using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface IAfterScript: 
    //going up 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation,
    //going up 1 level(s)
    IArtifactsNavigation,
    IBeforeScriptNavigation,
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation
{}

public interface IAfterScriptNavigation{
    public IAfterScript AfterScript(string[] commands);
}


    /*Use after_script to define an array of commands that run after each job, including failed jobs.
     Keyword type: Job keyword. You can use it only as part of a job or in the default section.
     Possible inputs: An array including:
     
     Single line commands.
     Long commands split over multiple lines.
     YAML anchors.*/
