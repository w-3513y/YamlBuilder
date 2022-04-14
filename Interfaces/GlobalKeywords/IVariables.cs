using YamlBuilder.Interfaces.JobsKeywords.IVariables;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IVariables:
    //going down 1 level(s)
    IKeyNavigation
{}

public interface IVariablesShortSyntax
{}

public interface IVariablesNavigation{
    public IVariablesShortSyntax Variables(Dictionary<string, string> keyValues);
    public IVariables Variables();
}