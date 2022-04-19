namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IIInclude_Project:
    IRefNavigation_lvl_2,
    IIInclude_File_Navigation_lvl_2
{}

public interface IInclude_Project_Navigation_lvl_1{
    public IIInclude_Project Project(string project);   
}