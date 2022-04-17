namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifact.IRepostTypes;

public interface ICoverageFormat:
    //going down 1 level(s)
    IPathNavigation
{}

public interface ICoverageFormatNavigation{
    public ICoverageFormat CoverageFormat(string format);
}