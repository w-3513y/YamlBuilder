namespace YamlBuilder.Interfaces.JobsKeywords.IWorkFlow;

public interface IChanges
    //going down 1 level(s)
{}

public interface IChangesNavigation{
    public IChanges Changes(string[] changes);
}