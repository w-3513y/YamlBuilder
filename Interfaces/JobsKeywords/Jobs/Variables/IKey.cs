namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Variables;

public interface IJobs_Variables_Key:
    IJobs_Variables_Value_Navigation_lvl_3
{
    public void Build(string key);
}

public interface IJobs_Variables_Key_Navigation_lvl_2{
    public IJobs_Variables_Key Key(string key);
}