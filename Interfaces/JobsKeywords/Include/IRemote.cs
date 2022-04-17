using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IRemote:
    //going up 3 level(s) abouve
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation
{}

public interface IRemoteNavigation{
    public IRemote Remote(string url);   
}