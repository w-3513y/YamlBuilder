using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.Default.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface IAfter_Script: 
    //going up 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    //going up 1 level(s)
    IArtifactsNavigation,
    IBefore_ScriptNavigation,
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation
{}

public interface IAfter_ScriptNavigation{
    public IAfter_Script After_Script(string[] commands);
}


    /*Use after_script to define an array of commands that run after each job, including failed jobs.
     Keyword type: Job keyword. You can use it only as part of a job or in the default section.
     Possible inputs: An array including:
     
     Single line commands.
     Long commands split over multiple lines.
     YAML anchors.*/
