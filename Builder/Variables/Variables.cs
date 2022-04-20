using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Builder.Variables;

public class VariablesShortSyntax : GitLabYaml, IVariablesShortSyntax
{
    public VariablesShortSyntax(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Variables : GitLabYaml, IVariables
{
     public Variables(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IVariables_Key Key(string key)
    {
        Utils.WriteFile(_fullPath, $"  {key.ToUpper()}:");
        return _serviceLocator.GetService<IVariables_Key>();
    }
}