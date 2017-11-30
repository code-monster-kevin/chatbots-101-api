using Chatbot101.API.Data.Entity;
using Chatbot101.API.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Chatbot101.API.Web.Controllers
{
    [Route("api/[controller]")]
    public class MainController : Controller
    {
        private IIncomingDataRepository _incomingDataRepository;

        public MainController(IIncomingDataRepository incomingDataRepository)
        {
            _incomingDataRepository = incomingDataRepository;
        }

        [HttpPost]
        [Route("incoming/{id}")]
        public async Task<IActionResult> Receive(string id)
        {
            string request_body = await ReadRequestBody(Request);
            IncomingData incoming_data = new IncomingData
            {
                ID = Guid.NewGuid(),
                ReferenceID = id,
                RawData = request_body,
                TimeStamp = DateTime.UtcNow,
                IsProcessed = false
            };

            _incomingDataRepository.SetIncomingData(incoming_data);
            _incomingDataRepository.Save();
            return Ok("Done");
        }

        private async Task<string> ReadRequestBody(HttpRequest httpRequest)
        {
            using (var stream_reader = new StreamReader(httpRequest.Body))
            {
                string request_body = await stream_reader.ReadToEndAsync();
                return request_body;
            }
        }
    }
}
