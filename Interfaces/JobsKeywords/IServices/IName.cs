using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords;

namespace YamlBuilder.Interfaces.Keywords.IServices;

public interface IName:
    //going up 4 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation,
    IVariablesNavigation,
    //going up 2 level(s)
    ITagsNavigation,
    ITimeOutNavigation,
    //going up 1 level(s)
    IAliasNavigation
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