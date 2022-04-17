namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IKey:
    //going down 1 level(s)
    IValueNavigation
 {}

public interface IKeyNavigation{
    public IKey Key(string key);
}