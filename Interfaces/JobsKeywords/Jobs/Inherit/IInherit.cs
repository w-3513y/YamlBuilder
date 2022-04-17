namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Inherit;

public interface IInherit: 
    //going up 3 level(s) abouve
    //going down 1 level(s)
    IDefaultNavigation,
    IVariablesNavigation
{}

public interface IInheritNavigation{
    public IInherit IInherit();
}