namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Cache;

public interface IJobs_Cache:
    IJobs_Cache_Key_Navigation_lvl_2,
    IJobs_Cache_Paths_Navigation_lvl_2,
    IJobs_Cache_Untracked_Navigation_lvl_2,
    IJobs_Cache_When_Navigation_lvl_2,
    IJobs_Cache_Policy_Navigation_lvl_2
{
    public void Build();
}

public interface IJobs_Cache_Navigation_lvl_1{
    public IJobs_Cache Cache();
}
