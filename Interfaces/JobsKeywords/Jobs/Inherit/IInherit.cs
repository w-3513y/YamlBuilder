namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Inherit;

public interface IInherit: 
    IDefaultNavigation_lvl_2,
    IVariablesNavigation_lvl_2
{}

public interface IInheritNavigation_lvl_1{
    public IInherit IInherit();
}