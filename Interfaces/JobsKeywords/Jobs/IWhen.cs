using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs;

public interface IJobs_When:
    IJobs_Navigation_lvl_0
{
    public void Build(Enums.Job when);
}

public interface IJobs_When_Navigation_lvl_1{
    public IJobs_When When(Enums.Job when);
}