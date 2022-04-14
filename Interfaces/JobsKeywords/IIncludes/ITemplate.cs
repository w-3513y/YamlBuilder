using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IIncludes;

public interface ITemplate:
    //going up 3 level(s) abouve
    IStagesNavigation,
    IVariablesNavigation
{}

public interface ITemplateNavigation{
    public ITemplate Template(string[] templates);   
}