namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IStages:
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0
{}

public interface IStagesNavigation_lvl_0{
    public IStages Stages(string[] stages);
}
