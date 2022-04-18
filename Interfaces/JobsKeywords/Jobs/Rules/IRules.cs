namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;


public interface IRules:
    IExistsNavigation,
    IIfsNavigation
    //going down 1 level(s)
 {}

public interface IRulesNavigation_lvl_1{
    public IRules Rules(string condition);
}