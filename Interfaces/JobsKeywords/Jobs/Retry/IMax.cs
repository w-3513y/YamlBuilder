namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;

public interface IJobs_Retry_Max:
    IJobs_Retry_When_Navigation_lvl_3
{}

public interface IJobs_Retry_Max_Navigation_lvl_2{
    public IJobs_Retry_Max Max(Enums.Retry retries);
}