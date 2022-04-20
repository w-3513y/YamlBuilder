using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Builder.Variables;

public class Key : Variables, IVariables_Key
{
    public Key(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string key) => Utils.WriteFile(_fullPath, $"  {key.ToUpper()}:");

    public IVariables_Value Value(string value)
    {
        _serviceLocator.GetService<IVariables_Value>().Build(value);
        return _serviceLocator.GetService<IVariables_Value>();
    }
}

public class Value : Key, IVariables_Value
{
    public Value(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IVariables_Description Description(string description)
    {
        _serviceLocator.GetService<IVariables_Description>().Build(description);
        return _serviceLocator.GetService<IVariables_Description>();
    }

    public new void Build(string value) => Utils.WriteFile(_fullPath, $"    value:  {value}");
}

public class Description : Variables, IVariables_Description
{
    public Description(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public void Build(string description) => Utils.WriteFile(_fullPath, $"    description:  {description}");
}
