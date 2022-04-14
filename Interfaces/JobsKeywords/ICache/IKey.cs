namespace YamlBuilder.Interfaces.JobsKeywords.ICaches;

public interface IKey{
    public IFiles Files(string[] files);
    public IPrefix Prefix(string name);
}
