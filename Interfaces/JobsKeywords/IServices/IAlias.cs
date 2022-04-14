using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;

namespace YamlBuilder.Interfaces.Keywords.IServices;

public interface IAlias:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    //going up 2 level(s)
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    IEntryPointNavigation,
    //recursive to run more than one service without short syntax
    INameAfterAliasNavigation
{}

public interface IAliasNavigation{
    public IAlias Alias(string alias);   
}