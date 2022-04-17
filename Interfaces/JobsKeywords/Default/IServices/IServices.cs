using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.Keywords.Default.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.IServices;

public interface IServices:
  //going down 1 level(s)
  INameNavigation
{}

public interface IServicesShortSyntax:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    //going up 2 level(s)
    ITagsNavigation,
    ITimeOutNavigation
{}


public interface IServicesNavigation{
    public IServices Services();   
    public IServicesShortSyntax Services(string[] commands);
}