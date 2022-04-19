namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IVariables_Key:
    IVariables_Value_Navigation_lvl_2
 {}

public interface IVariables_Key_Navigation_lvl_1{
    public IVariables_Key Key(string key);
}