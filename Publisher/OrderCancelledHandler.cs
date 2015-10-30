using Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher
{
public class OrderCancelledHandler : IHandleMessages<OrderCancelledEvent>
{
  public void Handle(OrderCancelledEvent message)
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("OrderCanclledEvent with id {0} received.", message.OrderId);
    Console.ResetColor();
  }
}
}
