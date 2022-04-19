namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IInclude_Ref:
    IInclude_File_Navigation_lvl_2
{}

public interface IInclude_Ref_Navigation_lvl_2{
    public IInclude_Ref Ref(string branch);
}