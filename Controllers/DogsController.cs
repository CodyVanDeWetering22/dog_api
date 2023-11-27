
namespace dog_api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class DogsController : ControllerBase
{

    private readonly DogsService _dogsService;

    public DogsController(DogsService dogsService)
    {
        _dogsService = dogsService;
    }

    [HttpGet]
    public ActionResult<List<Dog>> GetDogs()
    {

        try
        {
            List<Dog> dogs = _dogsService.GetDogs();
            return Ok(dogs);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }

    [HttpGet("{dogId}")]
    public ActionResult<Dog> GetDogById(int dogId)
    {
        try
        {
            Dog dog = _dogsService.GetDogById(dogId);
            return Ok(dog);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpPost]
    public ActionResult<Dog> CreateDog([FromBody] Dog dogData)
    {
        try
        {
            Dog dog = _dogsService.CreateDog(dogData);
            return Ok(dog);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpDelete("{dogId}")]
    public ActionResult<string> DestoryDog(int dogId)
    {
        try
        {
            string message = _dogsService.DestoryDog(dogId);
            return Ok(message);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
}