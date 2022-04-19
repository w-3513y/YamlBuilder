using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;

public interface IJobs_Artifacts:
  IJobs_Artifacts_Name_Navigation_lvl_2,
  IJobs_Artifacts_Paths_Navigation_lvl_2,
  IJobs_Artifacts_ExpireIn_Navigation_lvl_2,
  IJobs_Artifacts_Exclude_Navigation_lvl_2,
  IJobs_Artifacts_ExposeAs_Navigation_lvl_2,
  IJobs_Artifacts_Public_Navigation_lvl_2,
  IJobs_Artifacts_Report_Navigation_lvl_2,
  IJobs_Artifacts_Untracked_Navigation_lvl_2,
  IJobs_Artifacts_When_Navigation_lvl_2
{}

public interface IJobs_Artifacts_Navigation_lvl_1{
    public IJobs_Artifacts Artifacts();   
}
