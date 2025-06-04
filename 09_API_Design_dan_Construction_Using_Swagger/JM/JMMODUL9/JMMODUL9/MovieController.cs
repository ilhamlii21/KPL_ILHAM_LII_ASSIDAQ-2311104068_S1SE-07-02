using Microsoft.AspNetCore.Mvc;

namespace JMMODUL9
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> Movies = new List<Movie>
    {
        new Movie { Title = "Inception", Director = "Christopher Nolan", Stars = new List<string> { "Leonardo DiCaprio", "Joseph Gordon-Levitt" }, Description = "A thief enters dreams to steal secrets." },
        new Movie { Title = "Parasite", Director = "Bong Joon-ho", Stars = new List<string> { "Song Kang-ho", "Choi Woo-shik" }, Description = "A poor family schemes to infiltrate a wealthy household." },
        new Movie { Title = "Spirited Away", Director = "Hayao Miyazaki", Stars = new List<string> { "Rumi Hiiragi", "Miyu Irino" }, Description = "A girl enters a magical world ruled by spirits." }
    };

        [HttpGet]
        public ActionResult<List<Movie>> Get() => Movies;

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id) => (id < 0 || id >= Movies.Count) ? NotFound() : Movies[id];

        [HttpPost]
        public ActionResult Post([FromBody] Movie movie)
        {
            Movies.Add(movie);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= Movies.Count) return NotFound();
            Movies.RemoveAt(id);
            return Ok();
        }
    }
}