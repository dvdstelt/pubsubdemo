using Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      BusConfiguration configuration = new BusConfiguration();
      configuration.UseTransport<MsmqTransport>();
      configuration.UseSerialization<JsonSerializer>();

      ConventionsBuilder conventions = configuration.Conventions();
      conventions.DefiningCommandsAs(t => t.Namespace != null && t.Namespace == "Messages" && t.Name.EndsWith("Command"));

      CancelOrderCommand cmd = new CancelOrderCommand();
      cmd.OrderId = Guid.NewGuid();

      Console.WriteLine("When you're ready, press a key to send the command!");
      Console.ReadKey();

      using (ISendOnlyBus bus = Bus.CreateSendOnly(configuration))
      {
        Console.WriteLine("Sending CancelOrderCommand");
        bus.Send(cmd);
      }
    }
  }
}
