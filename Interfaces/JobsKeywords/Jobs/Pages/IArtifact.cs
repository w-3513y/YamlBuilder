namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IArtifact:
  //going down 1 level(s)
  IPathNavigation
{}

public interface IArtifactNavigation{
    public IArtifact Artifacts();   
}
