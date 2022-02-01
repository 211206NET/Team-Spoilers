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
        private IBL _bl;

        public AnswerController(IBL bl)
        {
            _bl = bl;
        }
        // // GET: api/<AnswerController>
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET api/<AnswerController>/5
        [HttpGet("{bingoCardID}")]
        public List<Answer> Get(int bingoCardID)
        {
            return _bl.GetAnswersbyBingoCardId(bingoCardID);
        }

        // POST api/<AnswerController>
        [HttpPost("{bingoCardID}")]
        public void Post([FromBody] Answer answerToAdd)
        {
            _bl.AddAnswer(answerToAdd);
        }

        // PUT api/<AnswerController>/5
        [HttpPut("{answerID}")]
        public void Put(int answerID, [FromBody] int marked)
        {
            //use update for Marking the answers
            //gonna need get answerbyId
            _bl.UpdateAnswer(answerID, marked);
        }

        // DELETE api/<AnswerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Answer answerToDelete = _bl.GetAnswerbyId(id);
            if(answerToDelete != null)
            {
                _bl.Delete(answerToDelete);
            }
        }
    }
}
