using Microsoft.AspNetCore.Mvc;
using TelegramChatBlazor.Domain.Abstract.Repository;
using TelegramChatBlazor.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TelegramChatBlazor.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiMessageController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;

        public ApiMessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ApiMessageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiMessageController>
        [HttpPost]
        public void Post([FromBody] Message value)
        {
            _messageRepository.Create(value);
            _messageRepository.Save();
        }

        // PUT api/<ApiMessageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiMessageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
