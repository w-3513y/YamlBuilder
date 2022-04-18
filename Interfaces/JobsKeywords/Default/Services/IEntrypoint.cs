namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IEntryPoint:
    //going down 1 level(s)
    ICommandNavigation_lvl_2
{}

public interface IEntryPointNavigation_lvl_3{
    public IEntryPoint Entrypoint(string entrypoint);
}