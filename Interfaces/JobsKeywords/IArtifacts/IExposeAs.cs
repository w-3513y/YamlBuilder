using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.Navigations;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts;

public interface IExposeAs: IArtifact, IDefault, IIncludeNavigation{

}

//Use the artifacts:expose_as keyword to expose job artifacts in the merge request UI.