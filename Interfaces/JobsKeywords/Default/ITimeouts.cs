using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface ITimeouts:
    //going up 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation
{}

public interface ITimeOutNavigation{
    public ITimeouts Timeouts(string time);
}