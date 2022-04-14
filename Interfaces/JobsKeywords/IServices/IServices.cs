using YamlBuilder.Interfaces.Keywords.IServices;

namespace YamlBuilder.Interfaces.JobsKeywords.IServices;

public interface IServices{
    public IName Name(string name);
    public IAlias Alias(string name);
    public IEntrypoint Entrypoint(string entrypoint);
    public ICommand Command(string command);
    public IVariables Variables(string[] variables);
}