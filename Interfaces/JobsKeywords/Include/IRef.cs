namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IRef:
    IFileNavigation_lvl_2
{}

public interface IRefNavigation_lvl_2{
    public IRef Ref(string branch);
}