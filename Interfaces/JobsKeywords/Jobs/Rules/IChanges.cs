namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;

public interface IChanges:
    IWhenNavigation_lvl_3,
    IAllowFailureNavigation_lvl_3    
{}

    public interface IChangesNavigation_lvl_3{
    public IChanges Changes(string[] changes);
}