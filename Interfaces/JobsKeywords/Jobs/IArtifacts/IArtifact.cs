using YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts.IRepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IArtifacts;

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
