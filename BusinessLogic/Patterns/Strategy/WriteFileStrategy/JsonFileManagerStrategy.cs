using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class JsonFileManagerStrategy : IFileManagerStrategy
    {
        private static string path = Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile) + "/ScoutConfig.json";

        public ScoutGroup loadFile()
        {
            ScoutGroup S = ScoutGroup.getInstance();
            S = JsonConvert.DeserializeObject<ScoutGroup>(File.ReadAllText(path));

            return S;
        }

        public void writeFile(ScoutGroup S)
        {   
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, S);
            }

        }
    }
}
