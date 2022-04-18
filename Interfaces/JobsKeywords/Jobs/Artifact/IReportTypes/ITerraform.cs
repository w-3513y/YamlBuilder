using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface ITerraform:
    IJobsNavigation_lvl_0,
    IExpireInNavigation_lvl_2
{}

public interface ITerraformNavigation_lvl_3{
    public ITerraform Terraform(string report);
}