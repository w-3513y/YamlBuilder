using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

namespace YamlBuilder.Builder.WorkFlow;

public class WorkFlow : GitLabYaml, IWorkFlow
{
     public WorkFlow(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build() => Utils.WriteFile(_fullPath, "workflow:");

    public IWorkFlow_Rules Rules(string condition)
    {
        throw new NotImplementedException();
    }
}