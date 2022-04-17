namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;

public interface ICache:
    //going down 1 level(s)
    IKeyNavigation,
    IPathsNavigation,
    IUntrackedNavigation,
    IWhenNavigation,
    IPolicyNavigation
{}

public interface ICacheNavigation{
    public ICache Cache();
}
