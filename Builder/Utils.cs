namespace YamlBuilder.Builder;

public static class Utils
{
     public static void WriteFile(string path, string content)
    {
        if (!File.Exists(path))
        {
            using var sw = File.CreateText(path);
            sw.WriteLine(content);
        }
        else
        {
            using var sw = File.AppendText(path);
            sw.WriteLine(content);
        }
    }   
}
