using YamlBuilder.Enums;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts;

//https://docs.gitlab.com/ee/ci/yaml/#artifacts
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

public interface IArtifactsNavigation{
    public IArtifacts Artifacts();   
}
