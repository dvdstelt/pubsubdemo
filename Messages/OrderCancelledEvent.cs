using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages
{
  public class OrderCancelledEvent
  {
    public Guid OrderId { get; set; }
  }
}
