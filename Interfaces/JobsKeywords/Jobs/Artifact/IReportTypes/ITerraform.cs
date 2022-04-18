using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

public interface ITerraform:
    //going up 5 level(s) abouve
    IJobsNavigation_lvl_0,
    //going up 3 level(s)
    //going up 2 level(s)
    IExpireInNavigation
{}

public interface ITerraformNavigation{
    public ITerraform Terraform(string report);
}