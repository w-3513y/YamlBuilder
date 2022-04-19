using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Builder.Variables;

public class VariablesShortSyntax : GitLabYaml, IVariablesShortSyntax
{
    public VariablesShortSyntax(string filePath) : base(filePath)
    {
    }
}

public class Variables : GitLabYaml, IVariables
{
     public Variables(string path) : base(path) {}

    public IVariables_Key Key(string key)
    {
        Utils.WriteFile(_fullPath, $"  {key.ToUpper()}:");
        return Utils.InvokeObject<IVariables_Key>(_fullPath);
    }
}