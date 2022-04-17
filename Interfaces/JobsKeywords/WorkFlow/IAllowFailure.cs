namespace YamlBuilder.Interfaces.JobsKeywords.WorkFlow;

public interface IAllowFailure
    //going down 1 level(s)
{}

public interface IAllowFailureNavigation{
    public IAllowFailure AllowFailure(bool yes);
}