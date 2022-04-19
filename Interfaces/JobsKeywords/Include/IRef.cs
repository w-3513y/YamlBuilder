namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IIInclude_Ref:
    IIInclude_File_Navigation_lvl_2
{}

public interface IRefNavigation_lvl_2{
    public IIInclude_Ref Ref(string branch);
}