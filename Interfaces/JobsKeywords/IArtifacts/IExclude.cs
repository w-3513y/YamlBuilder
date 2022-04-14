using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts;

public interface IExclude:
    //navigation 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    //going up 2 level(s)
    IBefore_ScriptNavigation,
    ICacheNavigation,
    IInterruptibleNavigation,
    IRetryNavigation,
    IServicesNavigation,
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    IExpireInNavigation,
    IReportNavigation
{}

public interface IExcludeNavigation{
    public IExclude Exclude(string file);
    
}
/*
    Use artifacts:exclude to prevent files from being added to an artifacts archive.
    Keyword type: Job keyword. You can use it only as part of a job or in the default section.
*/