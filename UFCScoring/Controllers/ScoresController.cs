using Microsoft.AspNetCore.Mvc;
using UFCScoring.Models;

namespace UFCScoring.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ScoresController : ControllerBase
{
    private static readonly List<Score> _scores = new();

    [HttpGet]
    public ActionResult<IEnumerable<Score>> GetScores()
    {
        return Ok(_scores);
    }

    [HttpPost]
    public IActionResult SubmitScore([FromBody] Score score)
    {
        _scores.Add(score);
        return Ok(score);
    }
}