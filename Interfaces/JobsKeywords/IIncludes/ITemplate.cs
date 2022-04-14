using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IIncludes;

public interface ITemplate:
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation
{}

public interface ITemplateNavigation{
    public ITemplate Template(string[] templates);   
}