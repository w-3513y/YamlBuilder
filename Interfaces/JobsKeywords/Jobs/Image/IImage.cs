using YamlBuilder.Interfaces.GlobalKeywords;

namespace YamlBuilder.Interfaces.JobsKeywords.Jobs.IImage;

public interface IImage:
    //going down 1 level(s)
    INameNavigation,
    IEntryPointNavigation
{}

public interface IImageShortSintax:
    //going up 3 level(s) abouve
    IJobsNavigation
    //going up 1 level(s)
{}

public interface IImageNavigation{

    public IImage Image();
    public IImageShortSintax Image(string image);
    
}