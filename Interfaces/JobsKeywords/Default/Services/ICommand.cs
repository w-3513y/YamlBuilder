using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface ICommand:
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    INameNavigation_lvl_2
{}

public interface ICommandNavigation_lvl_4{
    public ICommand Command(string command);
}