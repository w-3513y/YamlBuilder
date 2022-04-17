namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IChanges:
    //going down 1 level(s)
    IWhenNavigation,
    IAllowFailureNavigation    
{}

    public interface IChangesNavigation{
    public IChanges Changes(string[] changes);
}