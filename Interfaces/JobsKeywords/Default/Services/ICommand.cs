using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IDefault_Services_Command:
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1,
    IDefault_Services_Name_Navigation_lvl_2
{
    public void Build(string command);
}

public interface IDefault_Services_Command_Navigation_lvl_4{
    public IDefault_Services_Command Command(string command);
}