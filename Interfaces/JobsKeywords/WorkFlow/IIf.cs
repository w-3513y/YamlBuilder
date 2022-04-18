namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IIfs:
    IChangesNavigation_lvl_3,
    IVariablesNavigation_lvl_3,
    IWhenNavigation_lvl_3,
    IAllowFailureNavigation_lvl_3
 {}

public interface IIfsNavigation_lvl_2{
    public IIfs Ifs(string condition);
}