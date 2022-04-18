namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IStages:
    //going up 1 level(s)
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0
{}

public interface IStagesNavigation_lvl_0{
    public IStages Stages(string[] stages);
}
