namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Services;

public interface IEntryPoint:
    ICommandNavigation_lvl_4
{}

public interface IEntryPointNavigation_lvl_3{
    public IEntryPoint Entrypoint(string entrypoint);
}