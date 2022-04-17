using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Services;

public interface IServices:
  //going down 1 level(s)
  INameNavigation
{}

public interface IServicesShortSyntax:
    //going up 4 level(s) abouve
    IJobsNavigation
    //going up 2 level(s)
{}


public interface IServicesNavigation{
    public IServices Services();   
    public IServicesShortSyntax Services(string[] commands);
}