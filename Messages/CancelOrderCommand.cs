using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
  public class CancelOrderCommand
  {
    public Guid OrderId { get; set; }
  }
}