using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.Pages;

public interface IJobs_Pages_Path:
    IJobs_Navigation_lvl_0,
    IJobs_When_Navigation_lvl_1
{
    public void Build(string path);
}

public interface IJobs_Pages_Path_Navigation_lvl_3{

    public IJobs_Pages_Path Paths(string path);
    
}