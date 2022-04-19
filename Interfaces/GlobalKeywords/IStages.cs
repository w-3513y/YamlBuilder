namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IStages:
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0
{}

public interface IStages_Navigation_lvl_0{
    public IStages Stages(string[] stages);
}
