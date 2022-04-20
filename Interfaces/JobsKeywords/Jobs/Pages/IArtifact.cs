namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IJobs_Pages_Artifact:
  IJobs_Pages_Path_Navigation_lvl_3
{
  public void Build();
}

public interface IJobs_Pages_Artifact_Navigation_lvl_2{
    public IJobs_Pages_Artifact Artifacts();   
}
