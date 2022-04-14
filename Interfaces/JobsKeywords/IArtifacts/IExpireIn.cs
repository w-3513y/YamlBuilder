using YamlBuilder.Enums;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts;

public interface IExpireIn: IArtifact, INavigateGlobal{

}

/*
Use expire_in to specify how long job artifacts are stored before they expire and are deleted. The expire_in setting does not affect:
    Artifacts from the latest job, unless keeping the latest job artifacts is:
    Pipeline artifacts. You can’t specify an expiration date for pipeline artifacts. See When pipeline artifacts are deleted for more information.
*/