using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IDefault_Services_Name:
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1,
    IDefault_Services_Alias_Navigation_lvl_3,
    IDefault_Services_EntryPoint_Navigation_lvl_3
{
    public void Build(string serviceName);
}

public interface IDefault_Services_Name_Navigation_lvl_2{
    public IDefault_Services_Name Name(string serviceName);   
}