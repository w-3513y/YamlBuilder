using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IIncludes;

public interface ILocal:
    //going up 3 level(s) abouve
    IStagesNavigation,
    IVariablesNavigation
{}

public interface ILocalNavigation{
    public ILocal Local(string file);   
}