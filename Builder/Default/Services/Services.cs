using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Builder.Default.Services;

public class ServicesShortSyntax : Default, IDefault_ServicesShortSyntax
{
    public ServicesShortSyntax(string path) : base(path){}
}

public class Services : Default, IDefault_Services
{
    public Services(string path) : base(path){}

    public IDefault_Services_Name Name(string serviceName)
    {
        throw new NotImplementedException();
    }
}