using Confluent.Kafka;
using SwimTheWorld.PlayerApi.Domain;

namespace SwimTheWorld.PlayerApi.Infrastructure;

public class KafkaProducer
{
    public async Task AlertNewPlayer(Player player)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };
        using var producer = new ProducerBuilder<Null, Player>(config).Build();
        var result = await producer.ProduceAsync("user-registered", new Message<Null, Player> { Value = player });
    }
}
