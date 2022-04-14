using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts;

public interface IExposeAs: IArtifact, INavigateGlobal{

}

//Use the artifacts:expose_as keyword to expose job artifacts in the merge request UI.