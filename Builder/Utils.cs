using YamlBuilder.Configuration;

namespace YamlBuilder.Builder;

public static class Utils
{

    //public static T InvokeObject<T>(string path, IServiceLocator locator)
    //{
    //    T _object = locator.GetService<T>();
    //    return _object;
    //}

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
