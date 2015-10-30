using System;
using Messages;
using NServiceBus;

namespace Publisher
{
public class CancelOrderHandler : IHandleMessages<CancelOrderCommand>
{
  private readonly IBus Bus;

  public CancelOrderHandler(IBus bus)
  {
    Bus = bus;
  }

  public void Handle(CancelOrderCommand message)
  {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("CancelOrderCommand with id {0} received.", message.OrderId);

      Bus.Publish<OrderCancelledEvent>(m => m.OrderId = message.OrderId);

      Console.WriteLine("Published a CancelOrderCommand");
      Console.ResetColor();
    }
  }
}
