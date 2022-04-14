namespace YamlBuilder.Interfaces.JobsKeywords.IWorkFlow;

public interface IIfs:
    //going down 1 level(s)
    IVariablesNavigation

 {}

public interface IIfsNavigation{
    public IIfs Ifs(string condition);
}