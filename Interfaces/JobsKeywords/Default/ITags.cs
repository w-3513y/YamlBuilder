using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface ITags:
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    ITimeOutNavigation_lvl_1
 {}

public interface ITagsNavigation_lvl_1{
    public ITags Tags(string[] tags);
}