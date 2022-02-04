using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMDbController : ControllerBase
    {
        // GET: api/<IMDbController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<IMDbController>/5
        [HttpGet("{search}")]
        public async void Get(string search)
        {
            var API_URL = "imdb8.p.rapidapi.com";
            var API_KEY = "<Find in Proposal>";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://imdb8.p.rapidapi.com/auto-complete?q={search}"),
                Headers =
                {
                    { "x-rapidapi-host", API_URL },
                    { "x-rapidapi-key", API_KEY },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }

        // POST api/<IMDbController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IMDbController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IMDbController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
