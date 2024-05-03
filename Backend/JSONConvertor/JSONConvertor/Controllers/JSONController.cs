using JSONConvertor.Helper;
using JSONConvertor.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using System.Text.Json.Nodes;
using System.Xml;

namespace JSONConvertor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JSONController : ControllerBase
    {
        [HttpPost]
        [Route("json/validateJSON")]
        public IActionResult ValidateJSON([FromBody]JsonObject jsonContent)
        {
            LogHelper.LogInfo("Post request to Validate JSON");
            string jsonString = jsonContent.ToString();
            try
            {
                bool isValid = JSONtoXML.ValidateJSON(jsonString);
                if (!isValid)
                {
                    LogHelper.LogError("JSON is not valid");
                    return BadRequest("JSON is Invalid");
                }
                LogHelper.LogInfo("JSON is valid");
                return Ok();
            }catch(Exception ex)
            {
                LogHelper.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("json/convertJSONtoXML")]
        public IActionResult ConvertJSONtoXML([FromBody]JsonObject jsonContent)
        {
            LogHelper.LogError("Post request");
            string jsonString = jsonContent.ToString();
            try
            {
                XmlDocument xmlDoc = JSONtoXML.ConvertorJSONtoXML(jsonString);
                return Ok();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

    }
}
