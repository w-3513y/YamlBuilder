namespace YamlBuilder.Interfaces.JobsKeywords.Default.Cache;

public interface IDefault_Cache:
    IDefault_Cache_Key_Navigation_lvl_2,
    IDefault_Cache_Paths_Navigation_lvl_2,
    IDefault_Cache_Untracked_Navigation_lvl_2,
    IDefault_Cache_When_Navigation_lvl_2,
    IDefault_Cache_Policy_Navigation_lvl_2
{
    public void Build();
}

public interface IDefault_Cache_Navigation_lvl_1{

    public IDefault_Cache Cache();
    
}
