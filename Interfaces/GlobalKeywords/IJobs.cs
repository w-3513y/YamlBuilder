namespace YamlBuilder.Interfaces.GlobalKeywords;

public interface IJobs
{}

public interface IJobsNavigation{
    public IJobs Jobs(string[] stages);
}
