using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IIncludes;

public interface IRemote:
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation
{}

public interface IRemoteNavigation{
    public IRemote Remote(string url);   
}