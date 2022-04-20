using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IVariables_Value:
    IWorkFlow_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IVariables_Description_Navigation_lvl_3,
    IVariables_Key_Navigation_lvl_1
 {
     public void Build(string value);
 }

public interface IVariables_Value_Navigation_lvl_2{
    public IVariables_Value Value(string value);
}