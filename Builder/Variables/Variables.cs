using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Builder.Variables;

public class VariablesShortSyntax : GitLabYaml, IVariablesShortSyntax
{
    public VariablesShortSyntax(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(Dictionary<string, string> keyValuePairs)
    {
        Utils.WriteFile(_fullPath, "variables:");
        foreach(var values in keyValuePairs)
        {
            Utils.WriteFile(_fullPath, $"  {values.Key}: {values.Value}");
        }
    }
}

public class Variables : GitLabYaml, IVariables
{
     public Variables(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build()
    {
        Utils.WriteFile(_fullPath, "variables:");
    }

    public IVariables_Key Key(string key)
    {
        
        _serviceLocator.GetService<IVariables_Key>().Build(key);
        return _serviceLocator.GetService<IVariables_Key>();
    }
}