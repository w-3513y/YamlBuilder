using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Builder.Default.Services;


public class Name : Services, IDefault_Services_Name
{
    public Name(string path) : base(path){}

    public IDefault_Services_Alias Alias(string alias)
    {
        Utils.WriteFile(_fullPath, $"    alias: {alias}");
        return Utils.InvokeObject<IDefault_Services_Alias>(_fullPath);
    }

    public IDefault_Services_EntryPoint Entrypoint(string entrypoint)
    {
        Utils.WriteFile(_fullPath, $"    entrypoint: [{entrypoint}]");
        return Utils.InvokeObject<IDefault_Services_EntryPoint>(_fullPath);
    }
}

public class Alias : Name, IDefault_Services_Alias
{
    public Alias(string path) : base(path){}
}

public class Entrypoint : Alias, IDefault_Services_EntryPoint
{
    public Entrypoint(string path) : base(path){}

    public IDefault_Services_Command Command(string command)
    {
        Utils.WriteFile(_fullPath, $"    command: [{command}]");
        return Utils.InvokeObject<IDefault_Services_Command>(_fullPath);
    }
}

public class Command : Services, IDefault_Services_Command
{
    public Command(string path) : base(path){}
}