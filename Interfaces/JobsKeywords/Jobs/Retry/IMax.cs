namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;

public interface IMax:
    IWhenNavigation_lvl_3
{}

public interface IMaxNavigation_lvl_2{
    public IMax Max(Enums.Retry retries);
}