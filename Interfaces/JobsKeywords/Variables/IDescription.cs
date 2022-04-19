using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IVariables_Description:
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IVariables_Key_Navigation_lvl_1
 {}

public interface IVariables_Description_Navigation_lvl_3{
    public IVariables_Description Description(string description);
}