namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Services;

public interface IJobs_Services_EntryPoint:
    IJobs_Services_Command_Navigation_lvl_4
{}

public interface IJobs_Services_EntryPoint_Navigation_lvl_3{
    public IJobs_Services_EntryPoint Entrypoint(string entrypoint);
}