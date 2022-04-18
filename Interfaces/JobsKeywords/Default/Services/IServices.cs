using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IServices:
    INameNavigation_lvl_2
{}

public interface IServicesShortSyntax:
    IIncludeNavigation_lvl_0, 
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    ITagsNavigation_lvl_1,
    ITimeOutNavigation_lvl_1
{}


public interface IServicesNavigation_lvl_1{
    public IServices Services();   
    public IServicesShortSyntax Services(string[] commands);
}