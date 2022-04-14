namespace YamlBuilder.Interfaces.JobsKeywords.IVariables;

public interface IDescription:
    //recursive mode that make possible to have more than one project included
    IKeyNavigation
 {}

public interface IDescriptionNavigation{
    public IDescription Description(string description);
}