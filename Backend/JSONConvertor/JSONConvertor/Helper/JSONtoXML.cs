using System.Xml;
using Newtonsoft.Json;
using JSONConvertor.Helper;

namespace JSONConvertor.Model
{
    public static class JSONtoXML
    {
        private static string JSONContent = string.Empty;
        public static Boolean ValidateJSON(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
                return false;
            try
            {
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    DateParseHandling = DateParseHandling.None
                };
                JSONContent = JsonConvert.DeserializeObject(jsonString).ToString();
                LogHelper.LogInfo("Validated Sucessfully");
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex.Message);
                return false;
            }
        }
        public static XmlDocument ConvertorJSONtoXML(string jsonString)
        {
            XmlDocument xmlResponse = new XmlDocument();
            ValidateJSON(jsonString);

            xmlResponse = JsonConvert.DeserializeXmlNode(JSONContent, "root");
            LogHelper.LogInfo(xmlResponse.InnerXml);

            return xmlResponse;
        }

    }
}
