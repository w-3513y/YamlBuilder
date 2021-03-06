
using YamlBuilder.Interfaces.GitLab;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Interfaces.JobsKeywords.Default.Image;

public interface IDefault_Image:
    IDefault_Image_Name_Navigation_lvl_2,
    IDefault_Image_EntryPoint_Navigation_lvl_2
{
    public void Build();
}

public interface IDefault_ImageShortSyntax:
    IInclude_Navigation_lvl_0, 
    IStages_Navigation_lvl_0,
    IVariables_Navigation_lvl_0,
    IJobs_Navigation_lvl_0,
    IDefault_AfterScript_Navigation_lvl_1,
    IDefault_Artifacts_Navigation_lvl_1,
    IDefault_BeforeScript_Navigation_lvl_1,
    IDefault_Cache_Navigation_lvl_1,
    IDefault_Interruptible_Navigation_lvl_1,
    IDefault_Retry_Navigation_lvl_1,
    IDefault_Services_Navigation_lvl_1,
    IDefault_Tags_Navigation_lvl_1,
    IDefault_TimeOut_Navigation_lvl_1
{
    public void Build(string image);
}

public interface IImageNavigation_lvl_1{
    public IDefault_Image Image();
    public IDefault_ImageShortSyntax Image(string image);    
}