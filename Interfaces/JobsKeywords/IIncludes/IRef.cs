namespace YamlBuilder.Interfaces.JobsKeywords.IIncludes;

public interface IRef:
    //going down 1 level(s)
    IFileNavigation
{}

public interface IRefNavigation{
    public IRef Ref(string branch);
}