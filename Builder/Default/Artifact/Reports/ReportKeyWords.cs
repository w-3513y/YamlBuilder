using YamlBuilder.Builder.Default.Artifact.Reports;
using YamlBuilder.Configuration;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default.Artifact.Reports;

public class Acessibility : Report, IDefault_Artifacts_Report_Acessibility
{
    public Acessibility(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class CodeQuality : Report, IDefault_Artifacts_Report_CodeQuality
{
    public CodeQuality(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class CoverageReport : Report, IDefault_Artifacts_Report_CoverageReport
{
    public CoverageReport(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Artifacts_Report_CoverageFormat CoverageFormat(string format)
    {
        Utils.WriteFile(_fullPath, $"        coverage_format: {format}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_CoverageFormat>(_fullPath, _serviceLocator);
    }
}

public class CoverageFormat: CoverageReport, IDefault_Artifacts_Report_CoverageFormat
{
    public CoverageFormat(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}

    public IDefault_Artifacts_Report_Path Path(string path)
    {
        Utils.WriteFile(_fullPath, $"        path: {path}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_Path>(_fullPath, _serviceLocator);
    }
}

public class Path: CoverageFormat, IDefault_Artifacts_Report_Path
{
    public Path(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class DotEnv : Report, IDefault_Artifacts_Report_DotEnv
{
    public DotEnv(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class JUnit : Report, IDefault_Artifacts_Report_JUnit
{
    public JUnit(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Sast : Report, IDefault_Artifacts_Report_Sast
{
    public Sast(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class SecretDetection : Report, IDefault_Artifacts_Report_SecretDetection
{
    public SecretDetection(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}

public class Terraform : Report, IDefault_Artifacts_Report_Terraform
{
    public Terraform(string fullPath, IServiceLocator serviceLocator) 
        : base(fullPath, serviceLocator) {}
}