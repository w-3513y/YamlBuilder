using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IDefault_Services_Alias:
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1,
    IDefault_Services_Name_Navigation_lvl_2,
    IDefault_Services_EntryPoint_Navigation_lvl_3
{
    public void Build(string alias);
}

public interface IDefault_Services_Alias_Navigation_lvl_3{
    public IDefault_Services_Alias Alias(string alias);   
}