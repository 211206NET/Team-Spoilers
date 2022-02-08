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
        [HttpGet]
        public List<Answer> Get()
        {
            List<Answer> allAnswers = _bl.GetAllAnswers();
            return allAnswers;
        }

        // GET api/<AnswerController>/5
        [HttpGet("{bingoCardID}")]
        public List<Answer> Get(int bingoCardID)
        {
            return _bl.GetAnswersbyBingoCardId(bingoCardID);
        }

        // POST api/<AnswerController>
        [HttpPost("{bingoCardID}")]
        public Answer Post([FromBody] Answer answerToAdd)
        {
            return _bl.AddAnswer(answerToAdd.BingoCardID, answerToAdd);
        }

        // PUT api/<AnswerController>/5
        [HttpPut("{answerID}")]
        public Answer Put(int answerID, [FromBody] Answer answerToUpdate)
        {
            //use update for Marking the answers
            //gonna need get answerbyId
            return (Answer) _bl.Update(answerToUpdate);
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
