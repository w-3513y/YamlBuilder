using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Builder.Variables;

public class Key : Variables, IVariables_Key
{
    public Key(string path) : base(path) {}

    public IVariables_Value Value(string value)
    {
        Utils.WriteFile(_fullPath, $"    value:  {value}");
        return Utils.InvokeObject<IVariables_Value>(_fullPath);
    }
}

public class Value : Key, IVariables_Value
{
    public Value(string path) : base(path)
    {
    }

    public IVariables_Description Description(string description)
    {
        Utils.WriteFile(_fullPath, $"    description:  {description}");
        return Utils.InvokeObject<IVariables_Description>(_fullPath);
    }
}

public class Description : Variables, IVariables_Description
{
    public Description(string path) : base(path)
    {
    }
}
