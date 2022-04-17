using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface ITemplate:
    //going up 3 level(s) abouve
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation
{}

public interface ITemplateNavigation{
    public ITemplate Template(string[] templates);   
}