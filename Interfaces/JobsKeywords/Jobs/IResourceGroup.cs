using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IResourceGroup:
    //going up 3 level(s) abouve
    IJobsNavigation
{}

public interface IResourceGroupNavigation{
    public IResourceGroup ResourceGroup(string resource);
}