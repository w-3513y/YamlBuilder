namespace YamlBuilder.Interfaces.JobsKeywords.Variables;

public interface IKey:
    //going down 1 level(s)
    IValueNavigation_lvl_2
 {}

public interface IKeyNavigation_lvl_1{
    public IKey Key(string key);
}