namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;

public interface IRules:
    IExistsNavigation,
    IIfsNavigation
    //going down 1 level(s)
 {}

public interface IRulesNavigation{
    public IRules Rules(string condition);
}