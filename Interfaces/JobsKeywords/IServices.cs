using YamlBuilder.Interfaces.Keywords;

namespace YamlBuilder.Interfaces.JobsKeywords;

public interface IServices{
    public IName Name(string name);
    public IAlias Alias(string name);
    public IEntrypoint Entrypoint(string entrypoint);
}