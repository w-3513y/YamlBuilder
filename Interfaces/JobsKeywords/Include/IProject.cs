namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IInclude_Project:
    IInclude_Ref_Navigation_lvl_2,
    IInclude_File_Navigation_lvl_2
{}

public interface IInclude_Project_Navigation_lvl_1{
    public IInclude_Project Project(string project);   
}