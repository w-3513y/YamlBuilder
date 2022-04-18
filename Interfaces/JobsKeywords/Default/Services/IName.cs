using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IName:
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1,
    IAliasNavigation_lvl_3,
    IEntryPointNavigation_lvl_3
{}

public interface INameAfterAlias:
    IAliasNavigation_lvl_3
{}

public interface INameNavigation_lvl_2{
    public IName Name(string serviceName);   
}

public interface INameAfterAliasNavigation_lvl_2{
    public INameAfterAlias Name(string serviceName);   
}