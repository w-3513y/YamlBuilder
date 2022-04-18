using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IFile:
    //going up 3 level(s) abouve
    IStagesNavigation_lvl_0,
    IVariablesNavigation_lvl_0,
    IWorkFlowNavigation_lvl_0,
    IJobsNavigation_lvl_0,
    //going up 1 level(s)
    //recursive mode that make possible to have more than one project included
    IProjectNavigation_lvl_1
{}

public interface IFileNavigation_lvl_2{
    public IFile File(string[] files);   
}