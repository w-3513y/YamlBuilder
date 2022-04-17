using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IServices:
  //going down 1 level(s)
  INameNavigation
{}

public interface IServicesShortSyntax:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation,
    //going up 2 level(s)
    ITagsNavigation,
    ITimeOutNavigation
{}


public interface IServicesNavigation{
    public IServices Services();   
    public IServicesShortSyntax Services(string[] commands);
}