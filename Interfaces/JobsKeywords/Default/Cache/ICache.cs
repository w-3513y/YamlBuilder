namespace YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

public interface ICache:
    //going down 1 level(s)
    IKeyNavigation_lvl_2,
    IPathsNavigation_lvl_2,
    IUntrackedNavigation_lvl_2,
    IWhenNavigation_lvl_2,
    IPolicyNavigation_lvl_2
{}

public interface ICacheNavigation_lvl_1{

    public ICache Cache();
    
}
