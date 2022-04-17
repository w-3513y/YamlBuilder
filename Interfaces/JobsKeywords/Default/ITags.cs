using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface ITags:
    //going up 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    //going up 1 level(s)
    ITimeOutNavigation
 {}

public interface ITagsNavigation{
    public ITags Tags(string[] tags);
}