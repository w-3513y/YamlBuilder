namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;

public interface ICache:
    IKeyNavigation_lvl_2,
    IPathsNavigation_lvl_2,
    IUntrackedNavigation_lvl_2,
    IWhenNavigation_lvl_2,
    IPolicyNavigation_lvl_2
{}

public interface ICacheNavigation_lvl_1{
    public ICache Cache();
}
