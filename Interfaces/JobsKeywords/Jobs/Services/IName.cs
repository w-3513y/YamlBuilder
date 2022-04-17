using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Services;

public interface IName:
    //going up 4 level(s) abouve
    IJobsNavigation,
    //going up 2 level(s)
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