namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Only;

public interface IRef
    //going down 1 level(s)
{}

public interface IRefNavigation{
    public IRef Ref(string[] branch);
}