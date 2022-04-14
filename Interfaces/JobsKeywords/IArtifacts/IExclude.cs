using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.Navigations;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts;

public interface IExclude: IArtifact, IDefault, IIncludeNavigation{

}
/*
    Use artifacts:exclude to prevent files from being added to an artifacts archive.
    Keyword type: Job keyword. You can use it only as part of a job or in the default section.
*/