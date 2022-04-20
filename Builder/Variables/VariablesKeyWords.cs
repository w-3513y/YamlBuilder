using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Builder.Variables;

public class Key : Variables, IVariables_Key
{
    public Key(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IVariables_Value Value(string value)
    {
        Utils.WriteFile(_fullPath, $"    value:  {value}");
        return _serviceLocator.GetService<IVariables_Value>();
    }
}

public class Value : Key, IVariables_Value
{
    public Value(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IVariables_Description Description(string description)
    {
        Utils.WriteFile(_fullPath, $"    description:  {description}");
        return _serviceLocator.GetService<IVariables_Description>();
    }
}

public class Description : Variables, IVariables_Description
{
    public Description(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}
