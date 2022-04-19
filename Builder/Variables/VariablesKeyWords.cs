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
        return Utils.InvokeObject<IVariables_Value>(_fullPath, _serviceLocator);
    }
}

public class Value : Key, IVariables_Value
{
    public Value(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IVariables_Description Description(string description)
    {
        Utils.WriteFile(_fullPath, $"    description:  {description}");
        return Utils.InvokeObject<IVariables_Description>(_fullPath, _serviceLocator);
    }
}

public class Description : Variables, IVariables_Description
{
    public Description(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}
