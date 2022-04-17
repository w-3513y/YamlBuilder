using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifact.IRepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifact;

public interface IExclude:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
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