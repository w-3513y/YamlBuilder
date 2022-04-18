using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IName:
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
    IAliasNavigation_lvl_3,
    IEntryPointNavigation_lvl_3
{}

public interface INameAfterAlias:
    //going up 1 level(s)
    IAliasNavigation_lvl_3
{}

public interface INameNavigation{
    public IName Name(string serviceName);   
}

public interface INameAfterAliasNavigation_lvl_2{
    public INameAfterAlias Name(string serviceName);   
}