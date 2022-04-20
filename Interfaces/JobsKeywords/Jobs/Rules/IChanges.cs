namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Rules;

public interface IJobs_Rules_Changes:
    IJobs_Rules_When_Navigation_lvl_3,
    IJobs_Rules_AllowFailure_Navigation_lvl_3    
{
    public void Build(string[] changes);
}

    public interface IJobs_Rules_Changes_Navigation_lvl_3{
    public IJobs_Rules_Changes Changes(string[] changes);
}