namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Trigger;

public interface IJobs_Trigger_Foward:
    IJobs_Trigger_PipelineVariables_Navigation_lvl_3,
    IJobs_Trigger_YamlVariables_Navigation_lvl_3
{
    public void Build();
}

public interface IJobs_Trigger_Foward_Navigation_lvl_2{
    public IJobs_Trigger_Foward Foward();
}