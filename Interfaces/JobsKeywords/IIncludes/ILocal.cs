using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IIncludes;

public interface ILocal:
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation
{}

public interface ILocalNavigation{
    public ILocal Local(string file);   
}