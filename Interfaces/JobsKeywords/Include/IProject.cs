namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IProject:
    IRefNavigation_lvl_2,
    IFileNavigation_lvl_2
{}

public interface IProjectNavigation_lvl_1{
    public IProject Project(string project);   
}