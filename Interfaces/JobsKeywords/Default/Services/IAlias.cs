using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IAlias:
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    IEntryPointNavigation_lvl_3,
    INameAfterAliasNavigation_lvl_2
{}

public interface IAliasNavigation_lvl_3{
    public IAlias Alias(string alias);   
}