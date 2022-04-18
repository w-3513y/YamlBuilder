namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Retry;

public interface IMax:
    IWhenNavigation
{}

public interface IMaxNavigation{
    public IMax Max(Enums.Retry retries);
}