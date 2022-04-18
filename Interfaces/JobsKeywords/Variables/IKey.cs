namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IKey:
    IValueNavigation_lvl_2
 {}

public interface IKeyNavigation_lvl_1{
    public IKey Key(string key);
}