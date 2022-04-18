using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IFile:
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    IProjectNavigation_lvl_1
{}

public interface IFileNavigation_lvl_2{
    public IFile File(string[] files);   
}