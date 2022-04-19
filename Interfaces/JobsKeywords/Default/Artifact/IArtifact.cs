using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

public interface IDefault_Artifacts:
  IDefault_Artifacts_Name_Navigation_lvl_2,
  IDefault_Artifacts_Paths_Navigation_lvl_2,
  IDefault_Artifacts_ExpireIn_Navigation_lvl_2,
  IDefault_Artifacts_Exclude_Navigation_lvl_2,
  IDefault_Artifacts_ExposeAs_Navigation_lvl_2,
  IDefault_Artifacts_Public_Navigation_lvl_2,
  IDefault_Artifacts_Report_Navigation_lvl_2,
  IDefault_Artifacts_Untracked_Navigation_lvl_2,
  IDefault_Artifacts_When_Navigation_lvl_2
{}

public interface IIDefault_Artifacts_Artifacts_Navigation_lvl_1{
    public IDefault_Artifacts Artifacts();   
}
