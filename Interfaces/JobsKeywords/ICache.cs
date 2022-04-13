using YamlBuilder.Enums;
using YamlBuilder.Interfaces.Keywords;

namespace YamlBuilder.Interfaces.JobsKeywords;

public interface ICache{
    public IKey Key(string name);
    public IPaths Paths(string[] directories);
    public IUntracked Untracked(bool publ);
    public IWhen When(JobEnum onlyWhen);
    public IPolicy Policy(GitCommand command);
}
