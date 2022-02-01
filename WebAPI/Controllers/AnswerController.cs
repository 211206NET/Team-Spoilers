using Microsoft.AspNetCore.Mvc;
using Models;
using BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        // GET: api/<AnswerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AnswerController>/5
        [HttpGet("{bingoCardID}")]
        public List<AnswerController> Get(int bingoCardID)
        {
            return _bl.GetAnswersbyBingoCardId(bingoCardID);
        }

        // POST api/<AnswerController>
        [HttpPost("{bingoCardID}")]
        public void Post(int bingoCardID, [FromBody] Answer answerToAdd)
        {
            _bl.AddAnswer(bingoCardID, answerToAdd);
        }

        // PUT api/<AnswerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnswerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
