namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;

public interface IIfs:
    //going down 1 level(s)
    IChangesNavigation,
    IVariablesNavigation,
    IWhenNavigation,
    IAllowFailureNavigation
 {}

public interface IIfsNavigation{
    public IIfs Ifs(string condition);
}