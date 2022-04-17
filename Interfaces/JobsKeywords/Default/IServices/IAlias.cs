using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Interfaces.Keywords.Default.IServices;

public interface IAlias:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    //going up 2 level(s)
    ITagsNavigation,
    ITimeOutNavigation,
    //going down 1 level(s)
    IEntryPointNavigation,
    //recursive to run more than one service without short syntax
    INameAfterAliasNavigation
{}

public interface IAliasNavigation{
    public IAlias Alias(string alias);   
}