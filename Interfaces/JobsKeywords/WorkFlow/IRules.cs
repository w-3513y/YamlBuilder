namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IRules:
    IExistsNavigation_lvl_2,
    IIfsNavigation_lvl_2
 {}

public interface IRulesNavigation_lvl_1{
    public IRules Rules(string condition);
}