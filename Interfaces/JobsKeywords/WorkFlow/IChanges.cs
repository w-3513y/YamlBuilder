namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IChanges:
    //going down 1 level(s)
    IWhenNavigation_lvl_3,
    IAllowFailureNavigation_lvl_3    
{}

    public interface IChangesNavigation_lvl_3{
    public IChanges Changes(string[] changes);
}