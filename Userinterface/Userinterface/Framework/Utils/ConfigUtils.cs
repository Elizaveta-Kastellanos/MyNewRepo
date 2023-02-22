using Newtonsoft.Json;

namespace Userinterface.Framework.Utils
{
    public class ConfigUtils<T>
    {
        private static T modelConfig;

        public static T GetConfigDriver(string path)
        {
            if (modelConfig == null)
            {
                var reader = new JsonTextReader(new StreamReader(path));
                reader.SupportMultipleContent = true;
                reader.Read();
                modelConfig = new JsonSerializer().Deserialize<T>(reader);
            }
            return modelConfig;
        }
    }
}
