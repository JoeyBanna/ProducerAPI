using Confluent.Kafka;
using Microsoft.AspNetCore.Mvc;
using ProducerAPI.Repo;
using System.Text.Json;

namespace ProducerAPI.Controllers
{
    [Route("/api")]
    [ApiController]
    public class ProducerController:ControllerBase
    {
        private readonly IProducerRepo _producerRepo;
        private readonly ILogger<ProducerController> _logger;

        public ProducerController(IProducerRepo producerRepo, ILogger<ProducerController> logger)
        {
            _producerRepo = producerRepo;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetProducer(int id) 
        {
            try
            {
                throw new Exception("There was an error in the application");
            }catch (Exception ex)
            {
                _logger.LogError(ex,"Something went wrong",5);
            }

            _logger.LogInformation("Hello from action");
            if (id ==0)
            {
                return NotFound();
            }
            var obj = _producerRepo.GetProducer(id);
            if (obj == null)
            {
                return NoContent();
            }
            return Ok(obj);
        }


        [HttpPost]
        public  IActionResult PostProducer([FromBody] Models.ProducerEnt producer) 
        {
            try
            {
                _logger.LogInformation("Hello from action");

                _producerRepo.CreateProducer(producer);
                

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            return Ok(producer);
            
        }
    }
}
