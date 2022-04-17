namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IStages:
    //going up 1 level(s)
    IVariablesNavigation,
    IWorkFlowNavigation,
    IJobsNavigation
{}

public interface IStagesNavigation{
    public IStages Stages(string[] stages);
}
