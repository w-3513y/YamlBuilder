using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface ICommand:
    //going up 4 level(s) abouve
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    //going up 1 level(s)
    INameNavigation

{}

public interface ICommandNavigation_lvl_2{
    public ICommand Command(string command);
}