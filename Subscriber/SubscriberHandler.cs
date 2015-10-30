using Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber
{
  public class SubscriberHandler : IHandleMessages<OrderCancelledEvent>
  {
    public void Handle(OrderCancelledEvent message)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("OrderCancelledEvent with id {0} received.", message.OrderId);
      Console.ResetColor();
    }
  }
}
