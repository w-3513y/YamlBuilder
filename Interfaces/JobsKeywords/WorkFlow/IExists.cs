namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IExists:
    //going down 1 level(s)
    IVariablesNavigation
 {}

public interface IExistsNavigation{
    public IExists Exists(string condition);
}