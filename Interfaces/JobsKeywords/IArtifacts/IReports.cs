using YamlBuilder.Interfaces.JobsKeywords.IArtifacts.IRepostTypes;

namespace YamlBuilder.Interfaces.JobsKeywords.IArtifacts;

public interface IReport {

    public IAcessibility Acessibility(string report);
    public ICodeQuality CodeQuality(string report);
    public ICoverageReport CoverageReport();
    public IDotEnv DotEnv(string report);
    public IJUnit JUnit(string report);
    public ISast Sast(string report);
    public ISecretSedention SecretSedention(string report);
    public ITerraform Terraform(string report);
}
