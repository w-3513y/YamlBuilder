namespace YamlBuilder.Interfaces.Keywords;

public interface IKey{
    public IFiles Files(string[] files);
    public IPrefix Prefix(string name);
}
