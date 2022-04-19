using YamlBuilder.Builder.Default.Artifact.Reports;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;

namespace YamlBuilder.Builder.Default.Artifact.Reports;

public class Acessibility : Report, IDefault_Artifacts_Report_Acessibility
{
    public Acessibility(string path) : base(path){}
}

public class CodeQuality : Report, IDefault_Artifacts_Report_CodeQuality
{
    public CodeQuality(string path) : base(path){}
}

public class CoverageReport : Report, IDefault_Artifacts_Report_CoverageReport
{
    public CoverageReport(string path) : base(path){}

    public IDefault_Artifacts_Report_CoverageFormat CoverageFormat(string format)
    {
        Utils.WriteFile(_fullPath, $"        coverage_format: {format}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_CoverageFormat>(_fullPath);
    }
}

public class CoverageFormat: CoverageReport, IDefault_Artifacts_Report_CoverageFormat
{
    public CoverageFormat(string path) : base(path){}

    public IDefault_Artifacts_Report_Path Path(string path)
    {
        Utils.WriteFile(_fullPath, $"        path: {path}");
        return Utils.InvokeObject<IDefault_Artifacts_Report_Path>(_fullPath);
    }
}

public class Path: CoverageFormat, IDefault_Artifacts_Report_Path
{
    public Path(string path) : base(path){}
}

public class DotEnv : Report, IDefault_Artifacts_Report_DotEnv
{
    public DotEnv(string path) : base(path){}
}

public class JUnit : Report, IDefault_Artifacts_Report_JUnit
{
    public JUnit(string path) : base(path){}
}

public class Sast : Report, IDefault_Artifacts_Report_Sast
{
    public Sast(string path) : base(path){}
}

public class SecretDetection : Report, IDefault_Artifacts_Report_SecretDetection
{
    public SecretDetection(string path) : base(path){}
}

public class Terraform : Report, IDefault_Artifacts_Report_Terraform
{
    public Terraform(string path) : base(path){}
}