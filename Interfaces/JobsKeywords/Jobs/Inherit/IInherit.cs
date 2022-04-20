namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Inherit;

public interface IJobs_Inherit: 
    IJobs_Inherit_Default_Navigation_lvl_2,
    IJobs_Inherit_Variables_Navigation_lvl_2
{
    
}

public interface IJobs_Inherit_Navigation_lvl_1{
    public IJobs_Inherit IInherit();
}