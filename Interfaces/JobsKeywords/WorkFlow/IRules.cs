namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IRules:
    IExistsNavigation_lvl_2,
    IIfsNavigation_lvl_2
    //going down 1 level(s)
 {}

public interface IRulesNavigation_lvl_1{
    public IRules Rules(string condition);
}