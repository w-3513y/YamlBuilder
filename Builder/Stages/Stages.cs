using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Builder.Stages;

public class Stages : GitLabYaml, IStages
{
     public Stages(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}