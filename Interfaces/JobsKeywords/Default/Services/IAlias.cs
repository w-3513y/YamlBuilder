using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IAlias:
    //going up 4 level(s) abouve
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    //going up 2 level(s)
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    //going down 1 level(s)
    IEntryPointNavigation_lvl_3,
    //recursive to run more than one service without short syntax
    INameAfterAliasNavigation_lvl_2
{}

public interface IAliasNavigation_lvl_3{
    public IAlias Alias(string alias);   
}