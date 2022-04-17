using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;

namespace YamlBuilder.Interfaces.Keywords.Default.IServices;

public interface IName:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    IWorkFlowNavigation,
    //going up 2 level(s)
    ITagsNavigation,
    ITimeOutNavigation,
    //going down 1 level(s)
    IAliasNavigation,
    IEntryPointNavigation
{}

public interface INameAfterAlias:
    //going up 1 level(s)
    IAliasNavigation
{}

public interface INameNavigation{
    public IName Name(string serviceName);   
}

public interface INameAfterAliasNavigation{
    public INameAfterAlias Name(string serviceName);   
}