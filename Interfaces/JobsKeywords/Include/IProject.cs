namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IProject:
    //going down 1 level(s)
    IRefNavigation,
    IFileNavigation
{}

public interface IProjectNavigation{
    public IProject Project(string project);   
}