namespace ProducerAPI.Repo
{
    public interface IProducerRepo
    {

        Task CreateProducer(Models.ProducerEnt producer);
        Task<Models.ProducerEnt> GetProducer(int Id);

    }
}
