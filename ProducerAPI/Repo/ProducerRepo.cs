using Confluent.Kafka;
using Microsoft.EntityFrameworkCore;
using ProducerAPI.Data;
using ProducerAPI.Models;
using System.Text.Json;

namespace ProducerAPI.Repo
{
    public class ProducerRepo : IProducerRepo
    {
        private readonly ApplicationDbContext _context;

        public ProducerRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateProducer(ProducerEnt producer)
        {
            await _context.Producers.AddAsync(producer);
            await _context.SaveChangesAsync();

         //   var config = new ProducerConfig { BootstrapServers = "localhost:9092" };
          //  using var producera = new ProducerBuilder<Null, string>(config).Build();

         //   string jsonString = JsonSerializer.Serialize(producer);


          //  var response = await producera.ProduceAsync("ProducerMessage", new Message<Null, string> { Value = jsonString });
            //Console.WriteLine(response.Value);
        }

        public async Task<ProducerEnt> GetProducer(int Id)
        {
          var obj = await _context.Producers.SingleOrDefaultAsync(opt=> opt.Id == Id);
            if (obj == null)
            {
                throw new Exception("There is no product with that Id");
            }
            return obj;
          
        }
    }
}
