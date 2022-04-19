using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Include;

public interface IInclude_File:
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IInclude_Project_Navigation_lvl_1
{}

public interface IInclude_File_Navigation_lvl_2{
    public IInclude_File File(string[] files);   
}