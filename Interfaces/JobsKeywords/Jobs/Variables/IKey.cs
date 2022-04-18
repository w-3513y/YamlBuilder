namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Variables;

public interface IKey:
    IValueNavigation_lvl_3
 {}

public interface IKeyNavigation_lvl_2{
    public IKey Key(string key);
}