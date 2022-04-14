using YamlBuilder.Interfaces.JobsKeywords;
using YamlBuilder.Interfaces.JobsKeywords.IInclude;

namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IInclude{
    public ILocal Local(string file);
    public IFile File(string file);
    
}
