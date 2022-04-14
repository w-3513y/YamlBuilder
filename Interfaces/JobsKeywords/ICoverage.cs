using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.IArtifacts;
using YamlBuilder.Interfaces.JobsKeywords.ICaches;
using YamlBuilder.Interfaces.JobsKeywords.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords;

public interface ICoverage:
    //navigation 3 level(s) abouve
    IIncludeNavigation, 
    IStagesNavigation
{}

public interface ICoverageNavigation{
    public ICoverage Coverage();
}