namespace YamlBuilder.Interfaces.JobsKeywords.Default.Services;

public interface IDefault_Services_EntryPoint:
    IDefault_Services_Command_Navigation_lvl_4
{}

public interface IDefault_Services_EntryPoint_Navigation_lvl_3{
    public IDefault_Services_EntryPoint Entrypoint(string entrypoint);
}