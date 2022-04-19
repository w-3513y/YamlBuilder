using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Default;

public interface IDefault_Tags:
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_TimeOut_Navigation_lvl_1
 {}

public interface IDefault_Tags_Navigation_lvl_1{
    public IDefault_Tags Tags(string[] tags);
}