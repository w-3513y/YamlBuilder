using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Builder.Stages;

public class Stages : GitLabYaml, IStages
{
     public Stages(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string[] stages)
    {
        Utils.WriteFile(_fullPath, $"stages:");
        foreach (var stage in stages)
        {
            Utils.WriteFile(_fullPath, $"  - {stage}");
        }
    }
}