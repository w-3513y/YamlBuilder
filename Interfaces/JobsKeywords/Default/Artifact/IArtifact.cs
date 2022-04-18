using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;

public interface IArtifacts:
  INameNavigation_lvl_2,
  IPathsNavigation_lvl_2,
  IExpireInNavigation_lvl_2,
  IExcludeNavigation_lvl_2,
  IExposeAsNavigation_lvl_2,
  IPublicNavigation_lvl_2,
  IReportNavigation_lvl_2,
  IUntrackedNavigation_lvl_2,
  IWhenNavigation_lvl_2
{}

public interface IArtifactsNavigation_lvl_1{
    public IArtifacts Artifacts();   
}
