namespace YamlBuilder.Builder;

public abstract class BaseBuilder
{
    internal readonly string _fullPath;

    protected BaseBuilder(string fullPath)
    {
        _fullPath = fullPath;
    }
}