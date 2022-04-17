using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Services;

public interface IAlias:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
    //going down 1 level(s)
    IEntryPointNavigation,
    //recursive to run more than one service without short syntax
    INameAfterAliasNavigation
{}

public interface IAliasNavigation{
    public IAlias Alias(string alias);   
}