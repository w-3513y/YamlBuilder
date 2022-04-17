using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Interfaces.Keywords.Default.IServices;

public interface ICommand:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation,
    //going up 2 level(s)
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    INameNavigation

{}

public interface ICommandNavigation{
    public ICommand Command(string command);
}