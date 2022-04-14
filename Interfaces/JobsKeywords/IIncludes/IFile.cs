using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IIncludes;

public interface IFile:
    //going up 3 level(s) abouve
    IStagesNavigation,
    IVariablesNavigation,
    //going up 1 level(s)
    //recursive mode that make possible to have more than one project included
    IProjectNavigation
{}

public interface IFileNavigation{
    public IFile File(string[] files);   
}