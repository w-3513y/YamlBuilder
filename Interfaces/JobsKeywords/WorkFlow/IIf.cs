namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IWorkFlow_Ifs:
    IWorkFlow_Changes_Navigation_lvl_3,
    IWorkFlow_Variables_Navigation_lvl_3,
    IWorkFlow_When_Navigation_lvl_3,
    IWorkFlow_AllowFailure_Navigation_lvl_3
{
    public void Build(string condition);
}

public interface IWorkFlow_Ifs_Navigation_lvl_2{
    public IWorkFlow_Ifs Ifs(string condition);
}