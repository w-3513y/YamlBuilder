using YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact.RepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Artifact;

public interface IArtifacts:
  //going down 1 level(s)
  INameNavigation,
  IPathsNavigation,
  IExpireInNavigation,
  IExcludeNavigation,
  IExposeAsNavigation,
  IPublicNavigation,
  IReportNavigation,
  IUntrackedNavigation,
  IWhenNavigation
{}

public interface IArtifactsNavigation_lvl_1{
    public IArtifacts Artifacts();   
}
