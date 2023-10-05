using Microsoft.AspNetCore.Mvc;

namespace Crypterv2_RestAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class EncryptionController : ControllerBase
    {
        [HttpGet("broadcast")]
        public ActionResult<string> Broadcast()
        {
            return "Broadcasting information...";
        }

        [HttpPost("commands")]
        public ActionResult<string> ExecuteCommand([FromBody] CommandModel command)
        {
            if (command.Action == "shutdown") 
            {
                Environment.Exit(0);
            }
            return $"Executing command: {command.Action}";
        }

        [HttpPost("encrypt")]
        public ActionResult<string> Encrypt([FromBody] EncryptModel model)
        {
            return "Encryption completed.";
        }

        [HttpPost("decrypt")]
        public ActionResult<string> Decrypt([FromBody] DecryptModel model)
        {
            return "Decryption completed.";
        }

        [HttpGet("view/{filename}")]
        public ActionResult ViewFile(string filename) 
        {
            return null;//File( "application/octet-stream");
        }
    }

}
