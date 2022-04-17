namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IRules:
    IExistsNavigation,
    IIfsNavigation
    //going down 1 level(s)
 {}

public interface IRulesNavigation{
    public IRules Rules(string condition);
}