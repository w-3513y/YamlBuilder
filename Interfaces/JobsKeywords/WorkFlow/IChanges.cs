namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IWorkFlow_Changes:
    IWorkFlow_When_Navigation_lvl_3,
    IWorkFlow_AllowFailure_Navigation_lvl_3    
{}

    public interface IWorkFlow_Changes_Navigation_lvl_3{
    public IWorkFlow_Changes Changes(string[] changes);
}