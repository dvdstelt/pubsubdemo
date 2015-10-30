namespace Subscriber
{
  using NServiceBus;

public class EndpointConfig : IConfigureThisEndpoint
{
  public void Customize(BusConfiguration configuration)
  {
    configuration.EndpointName("subscriber");
    configuration.UseTransport<MsmqTransport>();
    configuration.UseSerialization<JsonSerializer>();
    configuration.UsePersistence<InMemoryPersistence>();

    ConventionsBuilder conventions = configuration.Conventions();
    conventions.DefiningCommandsAs(t => t.Namespace != null && t.Namespace == "Messages" && t.Name.EndsWith("Command"));
    conventions.DefiningEventsAs(t => t.Namespace != null && t.Namespace == "Messages" && t.Name.EndsWith("Event"));
  }
}
}
